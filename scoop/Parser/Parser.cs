using System;
using System.Collections;
using System.Collections.Generic;



namespace scoop
{

    public class Stack_element
    {
        public string symbol;
        public int State;
    }

    public class Parser
    {
        int cur_state;
        parseTable parse_t;
        ProductionTable prod_t;
        ArrayList ts; // this is token set
        Token t;
        int ti = -1; //token index
        Stack<Stack_element> parse_stack = new Stack<Stack_element>();
        Stack_element parse_ele;
        Stack_element tmp;

        public Parser(ArrayList ts_arg)
        {
            ts = ts_arg;
            parse_t = new parseTable();
            prod_t = new ProductionTable();

        }
       
        private String getSymbol()// i.e returns next token from the token set
        {
            String tmp_cur_sym = "";
            ti++;
            t = (Token)ts[ti];
            
            if (t.getClassPart().ToString() == "ID" | t.getClassPart().ToString() == "LIT")
                tmp_cur_sym = t.getClassPart().ToString();
            else
                tmp_cur_sym = t.getValuePart().ToString();

            return tmp_cur_sym;
        }
        private Action_Record getAction(String cur_symm)// i.e returns ACtion_Record
        {            
            cur_state = (int)(parse_stack.Peek()).State;            
            return parse_t.parse_tab.getItem(cur_state, cur_symm);
        }

        private void pushatStack(string sym, int st)
        {
            parse_ele = new Stack_element();
            parse_ele.State = st;
            parse_ele.symbol = sym;
            parse_stack.Push(parse_ele);
        }

        public void parse() // this implements YALA
        {
            //int cur_state;
            int cur_state_no;
            String cur_sym;     //gSymbol cur_sym;
            int cur_sym_no;
            Action_Record ar;
            int p;
            int lookaheadcount = 0;

            Console.WriteLine("Start Parsing... ");
            this.pushatStack("nothing", 0);//a=0 is start state---nothing as start symbol          
            cur_sym = this.getSymbol(); // get next token 
            ar = getAction(cur_sym);
            try
            {
                while (ti < ts.Count+1 )
                {


                    if (this.cur_state == 0 && cur_sym == "<program>")
                    { Console.WriteLine("Parsing Result =  success"); break; }


                     switch (ar.action)
                    {
                        case Action.Shift:
                            this.pushatStack(cur_sym, ar.prd_no_OR_nxt_pstate);

                            cur_sym = this.getSymbol();//get next token    
                            ar = getAction(cur_sym);
                            break;

                        case Action.Shift_Reduce:
                            p = ar.prd_no_OR_nxt_pstate;
                            cur_sym = prod_t.prd_tab[p].LHS.ToString();
                            for (int x = 0; x < ((prod_t.prd_tab[p].RHS_len) - 1); x++)
                                tmp = parse_stack.Pop();
                            ar = getAction(cur_sym);
                            break;

                        case Action.Reduce:
                            ti--;
                            p = ar.prd_no_OR_nxt_pstate;
                            cur_sym = prod_t.prd_tab[p].LHS.ToString();
                            for (int x = 0; x < prod_t.prd_tab[p].RHS_len; x++)
                                tmp = parse_stack.Pop();
                            ar = getAction(cur_sym);
                            break;

                        case Action.Look_Ahead:        //                
                            lookaheadcount++;
                            cur_sym = this.getSymbol();//get next token
                            ar = parse_t.parse_tab.getItem(ar.prd_no_OR_nxt_pstate, (object)cur_sym);
                            if (ar.action != Action.Look_Ahead)
                            { ti = ti - lookaheadcount; 
                              lookaheadcount = 0; 
                            }                           
                            break;

                        case Action.error:
                            Console.WriteLine("Parsing Result = syntax Error occured at token number " + ti + " at " + ((Token)ts[ti]).getValuePart());
                            ti = ts.Count+5;                  // enfore to exit the loop
                            break;

                    }//End Switch
                }//End while
            }// end try        
            catch (NullReferenceException e)
            {
                Console.WriteLine("Parsing Result = syntax Error occured at token number " + ti + " at token : " + ((Token)ts[ti]).getValuePart());

            }
        }




    }

}