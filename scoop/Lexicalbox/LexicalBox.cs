using System;
using System.Collections;

namespace scoop
{
public class LexicalBox {
	
	public static Hashtable knownClasses  = new Hashtable();
	
	static LexicalBox(){
		knownClasses["int"] = ClassPart.DT;
        knownClasses["float"] = ClassPart.DT;
        knownClasses["string"] = ClassPart.DT;
        knownClasses["boolean"] = ClassPart.DT;
		knownClasses["void"] = ClassPart.DT;
		knownClasses["if"] = ClassPart.IF;
        knownClasses["for"] = ClassPart.FOR;
		knownClasses["else"] = ClassPart.ELSE;
		knownClasses["("] = ClassPart.LP;
		knownClasses[")"] = ClassPart.RP;
		knownClasses["{"] = ClassPart.LB;
		knownClasses["}"] = ClassPart.RB;
		knownClasses[";"] = ClassPart.SC;
        knownClasses[":"] = ClassPart.COL;
        knownClasses["|"] = ClassPart.Seprator;
		knownClasses[","] = ClassPart.COMMA;
		knownClasses[">"] = ClassPart.REL_OP;
		knownClasses["<"] = ClassPart.REL_OP;
		knownClasses[">="] = ClassPart.REL_OP;
		knownClasses["<="] = ClassPart.REL_OP;
		knownClasses["=="] = ClassPart.REL_OP;
		knownClasses["!="] = ClassPart.REL_OP;
		knownClasses["="] = ClassPart.EQ_OP;
        knownClasses["++"] = ClassPart.INC_DEC_OP;
        knownClasses["--"] = ClassPart.INC_DEC_OP;
        knownClasses["+"] = ClassPart.plus_op;
        knownClasses["-"] = ClassPart.minus_op;
        knownClasses["/"] = ClassPart.div_op;
        knownClasses["*"] = ClassPart.mul_op;
        knownClasses["read"] = ClassPart.KW;        
        knownClasses["print"] = ClassPart.KW;
        knownClasses["new"] = ClassPart.KW;
        knownClasses["state"] = ClassPart.KW;
        knownClasses["statebinding"] = ClassPart.KW;
        knownClasses["while"] = ClassPart.KW;
        knownClasses["class"] = ClassPart.KW;
        knownClasses["this"] = ClassPart.KW;
        knownClasses["trans"] = ClassPart.KW;
        knownClasses["["] = ClassPart.LSB;
        knownClasses["]"] = ClassPart.RSB;
        knownClasses["public"] = ClassPart.SCOPE;
        knownClasses["private"] = ClassPart.SCOPE;
        knownClasses["AND"] = ClassPart.LOG_OP;
        knownClasses["OR"] = ClassPart.LOG_OP;
        knownClasses["."] = ClassPart.DOT;
        knownClasses["$$"] = ClassPart.EOF;
	}
	
	State s1;
	State s2;
	State s3;
	State s4;
	State s5;
	State s6;
	State s7;
	State s8;
	State s9;
	State s10;
	State s11;
	State s12;
    State s13;
    State s14;
    State s15;
	
	public LexicalBox() {
		
		s1 = new State("start", true, false);
		s2 = new State("identifier", false, true);
		s3 = new State("whiteSpace", false, true);	
		s4 = new State("punctuators", false, true);
		s5 = new State("eqOp", false, true);
		s6 = new State("relOp", false, true);
		s7 = new State("relOp", false, true);
		s8 = new State("!", false, false);
		s9 = new State("plusOp", false, true);
		s10 = new State("inc_dec_Op", false, true);
		s11 = new State("aritOp", false, true);
		s12 = new State("lit", false, true);
		s13 = new State(".", false, false);
		s14 = new State("lit", false, true);
        s15 = new State("\r", false, false);
		
		for(char c='A';c<='Z';c++) {
			s1.addTransition("" + c, s2);
			s2.addTransition("" + c, s2);
		}
		for(char c='a';c<='z';c++) {
			s1.addTransition("" + c, s2);
			s2.addTransition("" + c, s2);
		}
		for(char c='0';c<='9';c++) {
			s2.addTransition("" + c, s2);
			s1.addTransition("" + c, s12);
			s12.addTransition("" + c, s12);
			s13.addTransition("" + c, s14);
			s14.addTransition("" + c, s14);
		}
		
		s12.addTransition(".", s13);

		s2.addTransition("_", s2);
		
		s1.addTransition("" + ' ',  s3);
		s1.addTransition("" + '\t', s3);
		s1.addTransition("" + '\r', s15);
		s3.addTransition("" + ' ',  s3);
		s3.addTransition("" + '\t', s3);
        s15.addTransition("" + '\n', s3);
		
		s1.addTransition(";", s4);
        s1.addTransition(":", s4);
        s1.addTransition("|", s4);
		s1.addTransition(",", s4);
		s1.addTransition("(", s4);
		s1.addTransition(")", s4);
		s1.addTransition("{", s4);
		s1.addTransition("}", s4);
        s1.addTransition("[", s4);
        s1.addTransition("]", s4);
        s1.addTransition(".", s4);
		
		s1.addTransition("=", s5);
		s5.addTransition("=", s6);
		
		s1.addTransition(">", s7);
		s1.addTransition("<", s7);		
		s7.addTransition("=", s6);
		
		s1.addTransition("!", s8);
		s7.addTransition("=", s6);
        s8.addTransition("=", s6);

		s1.addTransition("+", s9);
		s9.addTransition("+", s10);		
		s1.addTransition("-", s9);
        s9.addTransition("-", s10);		

		s1.addTransition("*", s11);
		s1.addTransition("/", s11);	
			
		
		s2.setAction(new StateAction(identifierAction));	
		
		s3.setAction(new StateAction(whiteSpaceAction));				
		
		StateAction knownClassActionDelegate = new StateAction(knownClassAction);
		s4.setAction(knownClassAction);
		s5.setAction(knownClassAction);
		s6.setAction(knownClassAction);
		s7.setAction(knownClassAction);
		s9.setAction(knownClassAction);
		s10.setAction(knownClassAction);
		s11.setAction(knownClassAction);

        StateAction litActionDelegate = new StateAction(litAction);
		s12.setAction(litActionDelegate);
		s14.setAction(litActionDelegate);
				
	}
	
	public ArrayList analyze(String source) {
        source += "\r\n";
		DFA dfa = new DFA(s1);
        Console.WriteLine("Starting to Generat Token Set...");
		ArrayList tokens = dfa.run(source);
        Console.WriteLine("Token Set Generated");
		return tokens;
	}

			public Token identifierAction(String lexeme) {				
				Token token = null;				
				if(knownClasses.ContainsKey(lexeme)) {
					ClassPart classPart = (ClassPart)knownClasses[lexeme];
					token = new Token(classPart, lexeme);
				}else{				
					token = new Token(ClassPart.ID, lexeme);
				}
				return token;
			}

			public Token knownClassAction(String lexeme) {				
				Token token = null;				
				if(knownClasses.ContainsKey(lexeme)) {
					ClassPart classPart = (ClassPart)knownClasses[lexeme];
					token = new Token(classPart, lexeme);
				}				
				return token;
			}

   			public Token whiteSpaceAction(String lexeme) {				
				return null;
			}

            public Token litAction(String lexeme)
            {
                Token token = new Token(ClassPart.LIT, lexeme);
                return token;
            }

	
}

}
