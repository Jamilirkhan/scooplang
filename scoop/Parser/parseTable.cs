using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace scoop
{
    public enum Action
    {
        Shift,
        Reduce,
        Shift_Reduce,
        Look_Ahead,
        error
    }      

    
    public class Action_Record
    {
        public Action action;
        public int prd_no_OR_nxt_pstate;
        public Action_Record(Action a,int p_or_ns)
        {
            action = a;
            prd_no_OR_nxt_pstate = p_or_ns;
        }
        public Action_Record()
        {         
        }
        
    }
    
    class parseTable
    {
        public Hashtable2D parse_tab = new Hashtable2D();

        private Action_Record tmpRec;
        public parseTable()
        {
            this.populate_pTable();            
        }
        private void populate_pTable()
        {
            
            //initialize parse_tab here
            tmpRec = new Action_Record();
            
            
            for (int i = 0; i <= 196; i++)
            {
                parse_tab.AddRow(i);            
            }
           
            //populate parse_tab below: (The parse table is populated with the item set )

            
            //Item Set 0
            parse_tab.Add((object)0, (object)"<cls_list>".ToString(), new Action_Record(Action.Shift, 2));
            parse_tab.Add((object)0, (object)"$$".ToString(), new Action_Record(Action.Reduce,3));
            parse_tab.Add((object)0, (object)"[".ToString(), new Action_Record(Action.Reduce, 3));
            parse_tab.Add((object)0, (object)"class".ToString(), new Action_Record(Action.Reduce, 3));            
            //Item Set 1
            parse_tab.Add((object)1, (object)"state".ToString(), new Action_Record(Action.Shift, 4));
            //Item Set 2
            parse_tab.Add((object)2, (object)"$$".ToString(), new Action_Record(Action.Shift_Reduce, 1));
            parse_tab.Add((object)2, (object)"<class>".ToString(), new Action_Record(Action.Shift_Reduce, 2));
            parse_tab.Add((object)2, (object)"<st_dec_list>".ToString(), new Action_Record(Action.Shift, 3));
            parse_tab.Add((object)2, (object)"[".ToString(), new Action_Record(Action.Shift, 1));
            parse_tab.Add((object)2, (object)"class".ToString(), new Action_Record(Action.Reduce, 6));
            //Item Set 3
            parse_tab.Add((object)3, (object)"class".ToString(), new Action_Record(Action.Shift, 9));
            //Item Set 4
            parse_tab.Add((object)4, (object)"(".ToString(), new Action_Record(Action.Shift, 5));
            //Item Set 5
            parse_tab.Add((object)5, (object)"<st_list>".ToString(), new Action_Record(Action.Shift, 6));
            parse_tab.Add((object)5, (object)"<st_id>".ToString(), new Action_Record(Action.Shift_Reduce, 8));
            parse_tab.Add((object)5, (object)"ID".ToString(), new Action_Record(Action.Shift_Reduce, 9));
            //Item Set 6
            parse_tab.Add((object)6, (object)")".ToString(), new Action_Record(Action.Shift, 7));
            parse_tab.Add((object)6, (object)",".ToString(), new Action_Record(Action.Shift, 8));
            //Item Set 7
            parse_tab.Add((object)7, (object)"]".ToString(), new Action_Record(Action.Shift_Reduce, 5));
            //Item Set 8
            parse_tab.Add((object)8, (object)"<st_id>".ToString(), new Action_Record(Action.Shift_Reduce, 7));
            parse_tab.Add((object)8, (object)"ID".ToString(), new Action_Record(Action.Shift_Reduce, 9));
            //Item Set 9
            parse_tab.Add((object)9, (object)"ID".ToString(), new Action_Record(Action.Shift, 10));
            //Item Set 10
            parse_tab.Add((object)10, (object)"{".ToString(), new Action_Record(Action.Shift, 11));
            //Item Set 11
            parse_tab.Add((object)11, (object)"<cls_body>".ToString(), new Action_Record(Action.Shift, 12));
            parse_tab.Add((object)11, (object)"<var_dec_list>".ToString(), new Action_Record(Action.Shift, 13));            
            parse_tab.Add((object)11, (object)"[".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)11, (object)"}".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)11, (object)"statebinding".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)11, (object)"public".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)11, (object)"private".ToString(), new Action_Record(Action.Reduce, 12));
            //Item Set 12
            parse_tab.Add((object)12, (object)"}".ToString(), new Action_Record(Action.Shift_Reduce, 4));
            //Item Set 13
            parse_tab.Add((object)13, (object)"<st_binding>".ToString(), new Action_Record(Action.Shift, 17));
            parse_tab.Add((object)13, (object)"<var_dec>".ToString(), new Action_Record(Action.Shift, 18));
            parse_tab.Add((object)13, (object)"statebinding".ToString(), new Action_Record(Action.Shift, 23));
            parse_tab.Add((object)13, (object)"[".ToString(), new Action_Record(Action.Reduce, 23));
            parse_tab.Add((object)13, (object)"}".ToString(), new Action_Record(Action.Reduce, 23));
            parse_tab.Add((object)13, (object)"public".ToString(), new Action_Record(Action.Look_Ahead, 190));
            parse_tab.Add((object)13, (object)"private".ToString(), new Action_Record(Action.Look_Ahead, 190));
            parse_tab.Add((object)13, (object)"<vd_start>".ToString(), new Action_Record(Action.Shift, 16));
            parse_tab.Add((object)13, (object)"<pub-prv>".ToString(), new Action_Record(Action.Shift, 15));                   
            //Item Set 14
            parse_tab.Add((object)14, (object)"ID".ToString(), new Action_Record(Action.Shift_Reduce, 14));
            //Item Set 15
            parse_tab.Add((object)15, (object)"<dt>".ToString(), new Action_Record(Action.Shift, 26));
            parse_tab.Add((object)15, (object)"int".ToString(), new Action_Record(Action.Shift_Reduce, 15));
            parse_tab.Add((object)15, (object)"string".ToString(), new Action_Record(Action.Shift_Reduce, 16));
            parse_tab.Add((object)15, (object)"ID".ToString(), new Action_Record(Action.Shift_Reduce, 17));
            //Item Set 16
            parse_tab.Add((object)16, (object)"<vd_rest>".ToString(), new Action_Record(Action.Shift_Reduce, 13));
            parse_tab.Add((object)16, (object)"<vd_simple>".ToString(), new Action_Record(Action.Shift, 122));
            parse_tab.Add((object)16, (object)"<vd_new>".ToString(), new Action_Record(Action.Shift_Reduce, 118));            
            parse_tab.Add((object)16, (object)",".ToString(), new Action_Record(Action.Reduce, 120));
            parse_tab.Add((object)16, (object)";".ToString(), new Action_Record(Action.Reduce, 120));
            parse_tab.Add((object)16, (object)"=".ToString(), new Action_Record(Action.Shift, 19));         
            //Item Set 17
            parse_tab.Add((object)17, (object)"<cls_m_list>".ToString(), new Action_Record(Action.Shift, 21));
            parse_tab.Add((object)17, (object)"[".ToString(), new Action_Record(Action.Reduce, 25));
            parse_tab.Add((object)17, (object)"}".ToString(), new Action_Record(Action.Reduce, 25));
            parse_tab.Add((object)17, (object)"public".ToString(), new Action_Record(Action.Reduce, 25));
            parse_tab.Add((object)17, (object)"private".ToString(), new Action_Record(Action.Reduce, 25));
            //Item Set 18
            parse_tab.Add((object)18, (object)";".ToString(), new Action_Record(Action.Shift_Reduce, 11));            
            //Item Set 19
            parse_tab.Add((object)19, (object)"new".ToString(), new Action_Record(Action.Shift, 20));            
            //Item Set 20
            parse_tab.Add((object)20, (object)"ID".ToString(), new Action_Record(Action.Shift, 22));
            //Item Set 21
            parse_tab.Add((object)21, (object)"<c_s_m_list>".ToString(), new Action_Record(Action.Shift, 32));
            parse_tab.Add((object)21, (object)"<cls_method>".ToString(), new Action_Record(Action.Shift_Reduce, 24));
            parse_tab.Add((object)21, (object)"[".ToString(), new Action_Record(Action.Reduce, 77));
            parse_tab.Add((object)21, (object)"}".ToString(), new Action_Record(Action.Reduce, 77));
            parse_tab.Add((object)21, (object)"<pub-prv>".ToString(), new Action_Record(Action.Shift, 33));
            parse_tab.Add((object)21, (object)"public".ToString(), new Action_Record(Action.Shift_Reduce, 27));
            parse_tab.Add((object)21, (object)"private".ToString(), new Action_Record(Action.Shift_Reduce, 28));
            //Item Set 22
            parse_tab.Add((object)22, (object)"(".ToString(), new Action_Record(Action.Shift, 171));
            //Item Set 23
            parse_tab.Add((object)23, (object)"{".ToString(), new Action_Record(Action.Shift, 24));
            //Item Set 24
            parse_tab.Add((object)24, (object)"<b_list>".ToString(), new Action_Record(Action.Shift, 25));
            parse_tab.Add((object)24, (object)"<bind>".ToString(), new Action_Record(Action.Shift_Reduce, 20));
            parse_tab.Add((object)24, (object)"ID".ToString(), new Action_Record(Action.Shift, 27));            
            //Item Set 25
            parse_tab.Add((object)25, (object)"}".ToString(), new Action_Record(Action.Shift_Reduce, 18));
            parse_tab.Add((object)25, (object)",".ToString(), new Action_Record(Action.Shift, 28));
            //Item Set 26  
            parse_tab.Add((object)26, (object)"ID".ToString(), new Action_Record(Action.Shift_Reduce, 14));
            //Item Set 27
            parse_tab.Add((object)27, (object)":".ToString(), new Action_Record(Action.Shift, 29));
            //Item Set 28
            parse_tab.Add((object)28, (object)"<bind>".ToString(), new Action_Record(Action.Shift_Reduce, 19));
            parse_tab.Add((object)28, (object)"ID".ToString(), new Action_Record(Action.Shift, 27));
            //Item Set 29
            parse_tab.Add((object)29, (object)"(".ToString(), new Action_Record(Action.Shift, 30));
            //Item Set 30
            parse_tab.Add((object)30, (object)"<rel_exp>".ToString(), new Action_Record(Action.Shift, 31));
            parse_tab.Add((object)30, (object)"<rel_term>".ToString(), new Action_Record(Action.Shift_Reduce, 51));
            parse_tab.Add((object)30, (object)"<rel_fac>".ToString(), new Action_Record(Action.Shift, 98));
            parse_tab.Add((object)30, (object)"ID".ToString(), new Action_Record(Action.Shift, 81));
            parse_tab.Add((object)30, (object)"LIT".ToString(), new Action_Record(Action.Shift_Reduce, 55));          
            //Item Set 31
            parse_tab.Add((object)31, (object)"<rel_op>".ToString(), new Action_Record(Action.Shift, 97));
            parse_tab.Add((object)31, (object)")".ToString(), new Action_Record(Action.Shift_Reduce, 21));
            parse_tab.Add((object)31, (object)"AND".ToString(), new Action_Record(Action.Shift_Reduce, 57));
            parse_tab.Add((object)31, (object)"OR".ToString(), new Action_Record(Action.Shift_Reduce, 58));
            //Item Set 32
            parse_tab.Add((object)32, (object)"}".ToString(), new Action_Record(Action.Reduce, 10));
            parse_tab.Add((object)32, (object)"<c_s_method>".ToString(), new Action_Record(Action.Shift_Reduce, 78));
            parse_tab.Add((object)32, (object)"<s_list>".ToString(), new Action_Record(Action.Shift, 35));
            parse_tab.Add((object)32, (object)"<s_id>".ToString(), new Action_Record(Action.Shift_Reduce, 85));
            parse_tab.Add((object)32, (object)"[".ToString(), new Action_Record(Action.Shift, 42));
            //Item Set 33
            parse_tab.Add((object)33, (object)"<r_type>".ToString(), new Action_Record(Action.Shift, 45));
            parse_tab.Add((object)33, (object)"<dt>".ToString(), new Action_Record(Action.Shift_Reduce, 29));
            parse_tab.Add((object)33, (object)"int".ToString(), new Action_Record(Action.Shift_Reduce, 15));
            parse_tab.Add((object)33, (object)"string".ToString(), new Action_Record(Action.Shift_Reduce, 16));
            //Item Set 34
            parse_tab.Add((object)34, (object)"<s_list>".ToString(), new Action_Record(Action.Shift, 35));
            parse_tab.Add((object)34, (object)"<s_id>".ToString(), new Action_Record(Action.Shift_Reduce, 85));
            parse_tab.Add((object)34, (object)"[".ToString(), new Action_Record(Action.Shift, 42));
            //Item Set 35
            parse_tab.Add((object)35, (object)"{".ToString(), new Action_Record(Action.Shift, 43));
            parse_tab.Add((object)35, (object)",".ToString(), new Action_Record(Action.Shift, 41));
            //Item Set 36
            parse_tab.Add((object)36, (object)"]".ToString(), new Action_Record(Action.Shift, 37));
            //Item Set 37
            parse_tab.Add((object)37, (object)":".ToString(), new Action_Record(Action.Shift, 38));
            parse_tab.Add((object)37, (object)"{".ToString(), new Action_Record(Action.Reduce, 115));
            //Item Set 38
            parse_tab.Add((object)38, (object)"[".ToString(), new Action_Record(Action.Shift, 39));
            //Item Set 39
            parse_tab.Add((object)39, (object)"ID".ToString(), new Action_Record(Action.Shift, 40));
            //Item Set 40
            parse_tab.Add((object)40, (object)"]".ToString(), new Action_Record(Action.Shift_Reduce, 116));
            //Item Set 41
            parse_tab.Add((object)41, (object)"[".ToString(), new Action_Record(Action.Shift, 42));
            parse_tab.Add((object)41, (object)"<s_id>".ToString(), new Action_Record(Action.Shift_Reduce, 84));
            //Item Set 42
            parse_tab.Add((object)42, (object)"ID".ToString(), new Action_Record(Action.Shift, 36));
            //Item Set 43
            parse_tab.Add((object)43, (object)"<s_v_d_lst>".ToString(), new Action_Record(Action.Shift, 44));
            parse_tab.Add((object)43, (object)"int".ToString(), new Action_Record(Action.Reduce, 123));
            parse_tab.Add((object)43, (object)"ID".ToString(), new Action_Record(Action.Reduce, 123));
            parse_tab.Add((object)43, (object)"string".ToString(), new Action_Record(Action.Reduce, 123));
            parse_tab.Add((object)43, (object)"}".ToString(), new Action_Record(Action.Shift_Reduce, 79));            
            //Item Set 44
            parse_tab.Add((object)44, (object)"<s_m_list>".ToString(), new Action_Record(Action.Shift, 56));
            parse_tab.Add((object)44, (object)"<s_v_d>".ToString(), new Action_Record(Action.Shift, 174));
            parse_tab.Add((object)44, (object)"<s_vd_start>".ToString(), new Action_Record(Action.Shift, 175));            
            parse_tab.Add((object)44, (object)"<s_method>".ToString(), new Action_Record(Action.Shift_Reduce, 81));
            parse_tab.Add((object)44, (object)"<r_type>".ToString(), new Action_Record(Action.Shift, 57));
            parse_tab.Add((object)44, (object)"<dt>".ToString(), new Action_Record(Action.Shift, 172));
            parse_tab.Add((object)44, (object)"int".ToString(), new Action_Record(Action.Shift_Reduce, 15));
            parse_tab.Add((object)44, (object)"string".ToString(), new Action_Record(Action.Shift_Reduce, 16));
            parse_tab.Add((object)44, (object)"ID".ToString(), new Action_Record(Action.Shift_Reduce, 17));            
            //Item Set 45
            parse_tab.Add((object)45, (object)"<m_id>".ToString(), new Action_Record(Action.Shift, 46));
            parse_tab.Add((object)45, (object)"ID".ToString(), new Action_Record(Action.Shift_Reduce, 30));            
            //Item Set 46
            parse_tab.Add((object)46, (object)"(".ToString(), new Action_Record(Action.Shift, 47));            
            //Item Set 47
            parse_tab.Add((object)47, (object)"<arg_list>".ToString(), new Action_Record(Action.Shift, 50));
            parse_tab.Add((object)47, (object)")".ToString(), new Action_Record(Action.Reduce, 31));           
            parse_tab.Add((object)47, (object)"<args>".ToString(), new Action_Record(Action.Shift, 49));           
            parse_tab.Add((object)47, (object)"<arg>".ToString(), new Action_Record(Action.Shift_Reduce, 34));           
            parse_tab.Add((object)47, (object)"<dt>".ToString(), new Action_Record(Action.Shift, 48));           
            parse_tab.Add((object)47, (object)"int".ToString(), new Action_Record(Action.Shift_Reduce, 15));           
            parse_tab.Add((object)47, (object)"string".ToString(), new Action_Record(Action.Shift_Reduce, 16));           
            parse_tab.Add((object)47, (object)"ID".ToString(), new Action_Record(Action.Shift_Reduce, 17));                       
            //Item Set 48
            parse_tab.Add((object)48, (object)"ID".ToString(), new Action_Record(Action.Shift_Reduce, 35));      
            //Item Set 49
            parse_tab.Add((object)49, (object)")".ToString(), new Action_Record(Action.Reduce, 32));
            parse_tab.Add((object)49, (object)",".ToString(), new Action_Record(Action.Shift, 55));      
            //Item Set 50
            parse_tab.Add((object)50, (object)")".ToString(), new Action_Record(Action.Shift, 51));      
            //Item Set 51
            parse_tab.Add((object)51, (object)"{".ToString(), new Action_Record(Action.Shift, 52));      
            //Item Set 52
            parse_tab.Add((object)52, (object)"<m_body>".ToString(), new Action_Record(Action.Shift, 53));
            parse_tab.Add((object)52, (object)"<var_dec_list>".ToString(), new Action_Record(Action.Shift, 54));
            parse_tab.Add((object)52, (object)"}".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)52, (object)"read".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)52, (object)"print".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)52, (object)"ID".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)52, (object)"while".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)52, (object)"for".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)52, (object)"if".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)52, (object)"public".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)52, (object)"private".ToString(), new Action_Record(Action.Reduce, 12));      
            //Item Set 53
            parse_tab.Add((object)53, (object)"}".ToString(), new Action_Record(Action.Shift_Reduce, 26));            
            //Item Set 54
            parse_tab.Add((object)54, (object)"<stm_list>".ToString(), new Action_Record(Action.Shift, 132));
            parse_tab.Add((object)54, (object)"<var_dec>".ToString(), new Action_Record(Action.Shift, 18));     
            parse_tab.Add((object)54, (object)"}".ToString(), new Action_Record(Action.Reduce, 38));      
            parse_tab.Add((object)54, (object)"read".ToString(), new Action_Record(Action.Reduce, 38));      
            parse_tab.Add((object)54, (object)"print".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)54, (object)"ID".ToString(), new Action_Record(Action.Reduce, 38));      
            parse_tab.Add((object)54, (object)"if".ToString(), new Action_Record(Action.Reduce, 38));      
            parse_tab.Add((object)54, (object)"for".ToString(), new Action_Record(Action.Reduce, 38));      
            parse_tab.Add((object)54, (object)"while".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)54, (object)"<vd_start>".ToString(), new Action_Record(Action.Shift, 16));
            parse_tab.Add((object)54, (object)"<pub-prv>".ToString(), new Action_Record(Action.Shift, 15));
            parse_tab.Add((object)54, (object)"public".ToString(), new Action_Record(Action.Shift_Reduce, 27));
            parse_tab.Add((object)54, (object)"private".ToString(), new Action_Record(Action.Shift_Reduce, 28));
            //Item Set 55
            parse_tab.Add((object)55, (object)"<arg>".ToString(), new Action_Record(Action.Shift_Reduce, 33));
            parse_tab.Add((object)55, (object)"<dt>".ToString(), new Action_Record(Action.Shift,48));
            parse_tab.Add((object)55, (object)"int".ToString(), new Action_Record(Action.Shift_Reduce, 15));
            parse_tab.Add((object)55, (object)"string".ToString(), new Action_Record(Action.Shift_Reduce, 16));
            parse_tab.Add((object)55, (object)"ID".ToString(), new Action_Record(Action.Shift_Reduce, 17));
            //Item Set 56
            parse_tab.Add((object)56, (object)"}".ToString(), new Action_Record(Action.Shift_Reduce, 79));
            parse_tab.Add((object)56, (object)"<s_method>".ToString(), new Action_Record(Action.Shift_Reduce, 80));
            parse_tab.Add((object)56, (object)"<r_type>".ToString(), new Action_Record(Action.Shift, 57));
            parse_tab.Add((object)56, (object)"<dt>".ToString(), new Action_Record(Action.Shift_Reduce, 29));
            parse_tab.Add((object)56, (object)"int".ToString(), new Action_Record(Action.Shift_Reduce, 15));
            parse_tab.Add((object)56, (object)"string".ToString(), new Action_Record(Action.Shift_Reduce, 16));
            parse_tab.Add((object)56, (object)"ID".ToString(), new Action_Record(Action.Shift_Reduce, 17));
            //Item Set 57
            parse_tab.Add((object)57, (object)"<m_id>".ToString(), new Action_Record(Action.Shift,58));
            parse_tab.Add((object)57, (object)"ID".ToString(), new Action_Record(Action.Shift_Reduce, 30));
            //Item Set 58
            parse_tab.Add((object)58, (object)"(".ToString(), new Action_Record(Action.Shift, 59));
            //Item Set 59
            parse_tab.Add((object)59, (object)"<arg_list>".ToString(), new Action_Record(Action.Shift, 60));
            parse_tab.Add((object)59, (object)")".ToString(), new Action_Record(Action.Reduce, 31));
            parse_tab.Add((object)59, (object)"<args>".ToString(), new Action_Record(Action.Shift, 49));
            parse_tab.Add((object)59, (object)"<arg>".ToString(), new Action_Record(Action.Shift_Reduce, 34));
            parse_tab.Add((object)59, (object)"<dt>".ToString(), new Action_Record(Action.Shift, 48));
            parse_tab.Add((object)59, (object)"int".ToString(), new Action_Record(Action.Shift_Reduce, 15));
            parse_tab.Add((object)59, (object)"string".ToString(), new Action_Record(Action.Shift_Reduce, 16));
            parse_tab.Add((object)59, (object)"ID".ToString(), new Action_Record(Action.Shift_Reduce, 17));
            //Item Set 60
            parse_tab.Add((object)60, (object)")".ToString(), new Action_Record(Action.Shift, 61));
            //Item Set 61
            parse_tab.Add((object)61, (object)"<s_end_list>".ToString(), new Action_Record(Action.Shift, 62));
            parse_tab.Add((object)61, (object)"[".ToString(), new Action_Record(Action.Shift, 67));
            //Item Set 62
            parse_tab.Add((object)62, (object)"{".ToString(), new Action_Record(Action.Shift, 63));
            //Item Set 63
            parse_tab.Add((object)63, (object)"<s_m_body>".ToString(), new Action_Record(Action.Shift, 64));
            parse_tab.Add((object)63, (object)"<var_dec_list>".ToString(), new Action_Record(Action.Shift, 66));            
            parse_tab.Add((object)63, (object)"}".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)63, (object)"read".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)63, (object)"print".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)63, (object)"if".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)63, (object)"while".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)63, (object)"for".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)63, (object)"this".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)63, (object)"ID".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)63, (object)"public".ToString(), new Action_Record(Action.Reduce, 12));
            parse_tab.Add((object)63, (object)"private".ToString(), new Action_Record(Action.Reduce, 12));

            //Item Set 64
            parse_tab.Add((object)64, (object)"}".ToString(), new Action_Record(Action.Shift_Reduce, 82));
            //Item Set 65
            parse_tab.Add((object)65, (object)"<st_stm>".ToString(), new Action_Record(Action.Shift_Reduce, 89));
            parse_tab.Add((object)65, (object)"this".ToString(), new Action_Record(Action.Shift, 71));
            parse_tab.Add((object)65, (object)"}".ToString(), new Action_Record(Action.Shift_Reduce, 100));
            parse_tab.Add((object)65, (object)"while".ToString(), new Action_Record(Action.Shift, 72));
            parse_tab.Add((object)65, (object)"for".ToString(), new Action_Record(Action.Shift, 73));
            parse_tab.Add((object)65, (object)"if".ToString(), new Action_Record(Action.Shift, 74));
            parse_tab.Add((object)65, (object)"<lhs>".ToString(), new Action_Record(Action.Shift, 96));
            parse_tab.Add((object)65, (object)"ID".ToString(), new Action_Record(Action.Shift, 124));
            parse_tab.Add((object)65, (object)"read".ToString(), new Action_Record(Action.Shift, 94));
            parse_tab.Add((object)65, (object)"print".ToString(), new Action_Record(Action.Shift, 95));
            
            //Item Set 66
            parse_tab.Add((object)66, (object)"<s_stm_list>".ToString(), new Action_Record(Action.Shift, 70));
            parse_tab.Add((object)66, (object)"<var_dec>".ToString(), new Action_Record(Action.Shift, 18));
            parse_tab.Add((object)66, (object)"this".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)66, (object)"while".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)66, (object)"for".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)66, (object)"if".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)66, (object)"ID".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)66, (object)"read".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)66, (object)"print".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)66, (object)"}".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)66, (object)"<vd_start>".ToString(), new Action_Record(Action.Shift, 16));
            parse_tab.Add((object)66, (object)"<pub-prv>".ToString(), new Action_Record(Action.Shift, 15));
            parse_tab.Add((object)66, (object)"public".ToString(), new Action_Record(Action.Shift_Reduce, 15));
            parse_tab.Add((object)66, (object)"private".ToString(), new Action_Record(Action.Shift_Reduce, 16));                                  
            //Item Set 67
            parse_tab.Add((object)67, (object)"<s_e_list>".ToString(), new Action_Record(Action.Shift, 68));
            parse_tab.Add((object)67, (object)"ID".ToString(), new Action_Record(Action.Shift_Reduce, 87));
            //Item Set 68
            parse_tab.Add((object)68, (object)"]".ToString(), new Action_Record(Action.Shift_Reduce, 83));
            parse_tab.Add((object)68, (object)"|".ToString(), new Action_Record(Action.Shift, 69));
            //Item Set 69
            parse_tab.Add((object)69, (object)"ID".ToString(), new Action_Record(Action.Shift_Reduce, 86));
            //Item Set 70
            parse_tab.Add((object)70, (object)"}".ToString(), new Action_Record(Action.Reduce, 88));
            parse_tab.Add((object)70, (object)"<st_stm>".ToString(), new Action_Record(Action.Shift_Reduce, 89));
            parse_tab.Add((object)70, (object)"this".ToString(), new Action_Record(Action.Shift, 71));
            parse_tab.Add((object)70, (object)"while".ToString(), new Action_Record(Action.Shift, 72));
            parse_tab.Add((object)70, (object)"for".ToString(), new Action_Record(Action.Shift, 73));
            parse_tab.Add((object)70, (object)"if".ToString(), new Action_Record(Action.Shift, 74));            
            parse_tab.Add((object)70, (object)"<lhs>".ToString(), new Action_Record(Action.Shift, 96));
            parse_tab.Add((object)70, (object)"read".ToString(), new Action_Record(Action.Shift, 94));
            parse_tab.Add((object)70, (object)"print".ToString(), new Action_Record(Action.Shift, 95));
            parse_tab.Add((object)70, (object)"ID".ToString(), new Action_Record(Action.Shift, 124));
            //Item Set 71
            parse_tab.Add((object)71, (object)".".ToString(), new Action_Record(Action.Shift, 75));
            //Item Set 72
            parse_tab.Add((object)72, (object)"(".ToString(), new Action_Record(Action.Shift, 80));
            //Item Set 73
            parse_tab.Add((object)73, (object)"(".ToString(), new Action_Record(Action.Shift, 87));
            //Item Set 74
            parse_tab.Add((object)74, (object)"(".ToString(), new Action_Record(Action.Shift, 107));
            //Item Set 75
            parse_tab.Add((object)75, (object)"trans".ToString(), new Action_Record(Action.Shift, 76));            
            //Item Set 76
            parse_tab.Add((object)76, (object)"(".ToString(), new Action_Record(Action.Shift, 77));            
            //Item Set 77
            parse_tab.Add((object)77, (object)"ID".ToString(), new Action_Record(Action.Shift, 78));
            //Item Set 78
            parse_tab.Add((object)78, (object)")".ToString(), new Action_Record(Action.Shift, 79));
            //Item Set 79
            parse_tab.Add((object)79, (object)";".ToString(), new Action_Record(Action.Shift_Reduce, 91));
            //Item Set 80
            parse_tab.Add((object)80, (object)"<rel_exp>".ToString(), new Action_Record(Action.Shift, 83));
            parse_tab.Add((object)80, (object)"<rel_term>".ToString(), new Action_Record(Action.Shift_Reduce, 51));
            parse_tab.Add((object)80, (object)"<rel_fac>".ToString(), new Action_Record(Action.Shift, 98));
            parse_tab.Add((object)80, (object)"ID".ToString(), new Action_Record(Action.Shift, 81));
            parse_tab.Add((object)80, (object)"LIT".ToString(), new Action_Record(Action.Shift_Reduce, 55));
            //Item Set 81
            parse_tab.Add((object)81, (object)".".ToString(), new Action_Record(Action.Shift, 82));
            parse_tab.Add((object)81, (object)"AND".ToString(), new Action_Record(Action.Reduce, 54));
            parse_tab.Add((object)81, (object)"OR".ToString(), new Action_Record(Action.Reduce, 54));
            parse_tab.Add((object)81, (object)"==".ToString(), new Action_Record(Action.Reduce, 54));
            parse_tab.Add((object)81, (object)"!=".ToString(), new Action_Record(Action.Reduce, 54));
            parse_tab.Add((object)81, (object)"<=".ToString(), new Action_Record(Action.Reduce, 54));
            parse_tab.Add((object)81, (object)">=".ToString(), new Action_Record(Action.Reduce, 54));
            parse_tab.Add((object)81, (object)"<".ToString(), new Action_Record(Action.Reduce, 54));
            parse_tab.Add((object)81, (object)">".ToString(), new Action_Record(Action.Reduce, 54));
            parse_tab.Add((object)81, (object)";".ToString(), new Action_Record(Action.Reduce, 54));
            parse_tab.Add((object)81, (object)")".ToString(), new Action_Record(Action.Reduce, 54));
            //Item Set 82
            parse_tab.Add((object)82, (object)"ID".ToString(), new Action_Record(Action.Shift_Reduce, 56));
            //Item Set 83
            parse_tab.Add((object)83, (object)")".ToString(), new Action_Record(Action.Shift, 84));
            //Item Set 84
            parse_tab.Add((object)84, (object)"{".ToString(), new Action_Record(Action.Shift, 85));
            //Item Set 85
            parse_tab.Add((object)85, (object)"<s_stm_list>".ToString(), new Action_Record(Action.Shift, 86));
            parse_tab.Add((object)85, (object)"this".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)85, (object)"while".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)85, (object)"if".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)85, (object)"for".ToString(), new Action_Record(Action.Reduce, 90));                        
            parse_tab.Add((object)85, (object)"read".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)85, (object)"print".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)85, (object)"ID".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)85, (object)"}".ToString(), new Action_Record(Action.Reduce, 90));
            //Item Set 86
            parse_tab.Add((object)86, (object)"}".ToString(), new Action_Record(Action.Shift_Reduce, 97));
            parse_tab.Add((object)86, (object)"<st_stm>".ToString(), new Action_Record(Action.Shift_Reduce, 89));
            parse_tab.Add((object)86, (object)"this".ToString(), new Action_Record(Action.Shift, 71));
            parse_tab.Add((object)86, (object)"while".ToString(), new Action_Record(Action.Shift, 72));
            parse_tab.Add((object)86, (object)"for".ToString(), new Action_Record(Action.Shift, 73));
            parse_tab.Add((object)86, (object)"if".ToString(), new Action_Record(Action.Shift, 74));
            parse_tab.Add((object)86, (object)"<lhs>".ToString(), new Action_Record(Action.Shift, 96));
            parse_tab.Add((object)86, (object)"read".ToString(), new Action_Record(Action.Shift, 94));
            parse_tab.Add((object)86, (object)"print".ToString(), new Action_Record(Action.Shift, 95));
            parse_tab.Add((object)86, (object)"ID".ToString(), new Action_Record(Action.Shift, 124));          
            //Item Set 87
            parse_tab.Add((object)87, (object)"<init>".ToString(), new Action_Record(Action.Shift, 88));
            parse_tab.Add((object)87, (object)"ID".ToString(), new Action_Record(Action.Shift,183));
            //Item Set 88
            parse_tab.Add((object)88, (object)"<mid>".ToString(), new Action_Record(Action.Shift, 89));
            parse_tab.Add((object)88, (object)"<rel_exp>".ToString(), new Action_Record(Action.Shift_Reduce, 103));
            parse_tab.Add((object)88, (object)"<rel_term>".ToString(), new Action_Record(Action.Shift_Reduce, 51));
            parse_tab.Add((object)88, (object)"<rel_fac>".ToString(), new Action_Record(Action.Shift, 98));            
            parse_tab.Add((object)88, (object)"LIT".ToString(), new Action_Record(Action.Shift_Reduce, 55));
            parse_tab.Add((object)88, (object)"ID".ToString(), new Action_Record(Action.Shift, 81));
            //Item Set 89
            parse_tab.Add((object)89, (object)";".ToString(), new Action_Record(Action.Shift, 117));           
            //Item Set 90
            parse_tab.Add((object)90, (object)")".ToString(), new Action_Record(Action.Shift, 91));
            //Item Set 91
            parse_tab.Add((object)91, (object)"{".ToString(), new Action_Record(Action.Shift, 92));
            //Item Set 92
            parse_tab.Add((object)92, (object)"<s_stm_list>".ToString(), new Action_Record(Action.Shift, 93));
            parse_tab.Add((object)92, (object)"}".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)92, (object)"this".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)92, (object)"while".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)92, (object)"for".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)92, (object)"if".ToString(), new Action_Record(Action.Reduce, 90));            
            parse_tab.Add((object)92, (object)"read".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)92, (object)"print".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)92, (object)"ID".ToString(), new Action_Record(Action.Reduce, 90));
            //Item Set 93
            parse_tab.Add((object)93, (object)"}".ToString(), new Action_Record(Action.Shift_Reduce,98));
            parse_tab.Add((object)93, (object)"<st_stm>".ToString(), new Action_Record(Action.Shift_Reduce, 89));
            parse_tab.Add((object)93, (object)"this".ToString(), new Action_Record(Action.Shift, 71));
            parse_tab.Add((object)93, (object)"while".ToString(), new Action_Record(Action.Shift, 72));
            parse_tab.Add((object)93, (object)"for".ToString(), new Action_Record(Action.Shift, 73));
            parse_tab.Add((object)93, (object)"if".ToString(), new Action_Record(Action.Shift, 74));
            parse_tab.Add((object)93, (object)"read".ToString(), new Action_Record(Action.Shift, 94));
            parse_tab.Add((object)93, (object)"print".ToString(), new Action_Record(Action.Shift, 95));
            parse_tab.Add((object)93, (object)"ID".ToString(), new Action_Record(Action.Shift, 124));
            parse_tab.Add((object)93, (object)"<lhs>".ToString(), new Action_Record(Action.Shift, 96));            
            //Item Set 94
            parse_tab.Add((object)94, (object)"(".ToString(), new Action_Record(Action.Shift, 112));            
            //Item Set 95
            parse_tab.Add((object)95, (object)"<exp>".ToString(), new Action_Record(Action.Shift, 115));
            parse_tab.Add((object)95, (object)"<term>".ToString(), new Action_Record(Action.Shift, 116));
            parse_tab.Add((object)95, (object)"<factor>".ToString(), new Action_Record(Action.Shift_Reduce, 67));
            parse_tab.Add((object)95, (object)"(".ToString(), new Action_Record(Action.Shift, 104));
            parse_tab.Add((object)95, (object)"ID".ToString(), new Action_Record(Action.Shift, 187));
            parse_tab.Add((object)95, (object)"LIT".ToString(), new Action_Record(Action.Shift_Reduce, 72));
            //Item Set 96
            parse_tab.Add((object)96, (object)"=".ToString(), new Action_Record(Action.Shift, 100));
            //Item Set 97
            parse_tab.Add((object)97, (object)"<rel_term>".ToString(), new Action_Record(Action.Shift_Reduce, 49));
            parse_tab.Add((object)97, (object)"<rel_fac>".ToString(), new Action_Record(Action.Shift,98));
            parse_tab.Add((object)97, (object)"ID".ToString(), new Action_Record(Action.Shift, 81));
            parse_tab.Add((object)97, (object)"LIT".ToString(), new Action_Record(Action.Shift_Reduce, 55));
            //Item Set 98
            parse_tab.Add((object)98, (object)"<comp_op>".ToString(), new Action_Record(Action.Shift, 99));
            parse_tab.Add((object)98, (object)"==".ToString(), new Action_Record(Action.Shift_Reduce, 59));
            parse_tab.Add((object)98, (object)"!=".ToString(), new Action_Record(Action.Shift_Reduce, 60));
            parse_tab.Add((object)98, (object)"<=".ToString(), new Action_Record(Action.Shift_Reduce, 63));
            parse_tab.Add((object)98, (object)">=".ToString(), new Action_Record(Action.Shift_Reduce, 64));
            parse_tab.Add((object)98, (object)"<".ToString(), new Action_Record(Action.Shift_Reduce, 62));
            parse_tab.Add((object)98, (object)">".ToString(), new Action_Record(Action.Shift_Reduce, 61));
            //Item Set 99
            parse_tab.Add((object)99, (object)"<rel_fac>".ToString(), new Action_Record(Action.Shift_Reduce, 52));
            parse_tab.Add((object)99, (object)"ID".ToString(), new Action_Record(Action.Shift, 81));
            parse_tab.Add((object)99, (object)"LIT".ToString(), new Action_Record(Action.Shift_Reduce, 54));            
            //Item Set 100
            parse_tab.Add((object)100, (object)"<exp>".ToString(), new Action_Record(Action.Shift, 101));            
            parse_tab.Add((object)100, (object)"<factor>".ToString(), new Action_Record(Action.Shift_Reduce, 67));
            parse_tab.Add((object)100, (object)"<term>".ToString(), new Action_Record(Action.Shift, 116));            
            parse_tab.Add((object)100, (object)"(".ToString(), new Action_Record(Action.Shift, 104));
            parse_tab.Add((object)100, (object)"ID".ToString(), new Action_Record(Action.Shift, 187));
            parse_tab.Add((object)100, (object)"LIT".ToString(), new Action_Record(Action.Shift_Reduce, 72));
            //Item Set 101
            parse_tab.Add((object)101, (object)";".ToString(), new Action_Record(Action.Shift_Reduce, 92));
            parse_tab.Add((object)101, (object)"<add_op>".ToString(), new Action_Record(Action.Shift, 102));
            parse_tab.Add((object)101, (object)"+".ToString(), new Action_Record(Action.Shift_Reduce, 73));
            parse_tab.Add((object)101, (object)"-".ToString(), new Action_Record(Action.Shift_Reduce, 74));
            //Item Set 102
            parse_tab.Add((object)102, (object)"<term>".ToString(), new Action_Record(Action.Shift,103));
            parse_tab.Add((object)102, (object)"<factor>".ToString(), new Action_Record(Action.Shift_Reduce, 67));
            parse_tab.Add((object)102, (object)"(".ToString(), new Action_Record(Action.Shift,104));
            parse_tab.Add((object)102, (object)"ID".ToString(), new Action_Record(Action.Shift, 187));
            parse_tab.Add((object)102, (object)"LIT".ToString(), new Action_Record(Action.Shift_Reduce, 72));
            //Item Set 103
            parse_tab.Add((object)103, (object)";".ToString(), new Action_Record(Action.Reduce, 66));
            parse_tab.Add((object)103, (object)")".ToString(), new Action_Record(Action.Reduce, 66));
            parse_tab.Add((object)103, (object)"+".ToString(), new Action_Record(Action.Reduce, 66));
            parse_tab.Add((object)103, (object)"-".ToString(), new Action_Record(Action.Reduce, 66));

            parse_tab.Add((object)103, (object)"<mult_op>".ToString(), new Action_Record(Action.Shift, 105));
            parse_tab.Add((object)103, (object)"*".ToString(), new Action_Record(Action.Shift_Reduce, 75));
            parse_tab.Add((object)103, (object)"/".ToString(), new Action_Record(Action.Shift_Reduce, 76));
            //Item Set 104
            parse_tab.Add((object)104, (object)"<exp>".ToString(), new Action_Record(Action.Shift, 106));
            parse_tab.Add((object)104, (object)"<term>".ToString(), new Action_Record(Action.Shift_Reduce, 116));
            parse_tab.Add((object)104, (object)"<factor>".ToString(), new Action_Record(Action.Shift_Reduce, 67));
            parse_tab.Add((object)104, (object)"(".ToString(), new Action_Record(Action.Shift, 104));
            parse_tab.Add((object)104, (object)"ID".ToString(), new Action_Record(Action.Shift, 187));
            //Item Set 105
            parse_tab.Add((object)105, (object)"<factor>".ToString(), new Action_Record(Action.Shift_Reduce, 68));
            parse_tab.Add((object)105, (object)"(".ToString(), new Action_Record(Action.Shift, 104));
            parse_tab.Add((object)105, (object)"ID".ToString(), new Action_Record(Action.Shift, 187));
            parse_tab.Add((object)105, (object)"LIT".ToString(), new Action_Record(Action.Shift_Reduce, 72));            
            //Item Set 106
            parse_tab.Add((object)106, (object)")".ToString(), new Action_Record(Action.Shift_Reduce, 69));
            parse_tab.Add((object)106, (object)"<add_op>".ToString(), new Action_Record(Action.Shift, 102));
            parse_tab.Add((object)106, (object)"+".ToString(), new Action_Record(Action.Shift_Reduce, 73));
            parse_tab.Add((object)106, (object)"-".ToString(), new Action_Record(Action.Shift_Reduce, 74));
            //Item Set 107
            parse_tab.Add((object)107, (object)"<rel_exp>".ToString(), new Action_Record(Action.Shift, 108));
            parse_tab.Add((object)107, (object)"<rel_term>".ToString(), new Action_Record(Action.Shift_Reduce, 51));
            parse_tab.Add((object)107, (object)"<rel_fac>".ToString(), new Action_Record(Action.Shift, 98));
            parse_tab.Add((object)107, (object)"ID".ToString(), new Action_Record(Action.Shift, 81));
            parse_tab.Add((object)107, (object)"LIT".ToString(), new Action_Record(Action.Shift_Reduce, 55));
            //Item Set 108
            parse_tab.Add((object)108, (object)")".ToString(), new Action_Record(Action.Shift, 109));
            parse_tab.Add((object)108, (object)"<rel_op>".ToString(), new Action_Record(Action.Shift, 97));
            parse_tab.Add((object)108, (object)"AND".ToString(), new Action_Record(Action.Shift_Reduce, 57));
            parse_tab.Add((object)108, (object)"OR".ToString(), new Action_Record(Action.Shift_Reduce, 58));
            //Item Set 109
            parse_tab.Add((object)109, (object)"{".ToString(), new Action_Record(Action.Shift, 110));
            //Item Set 110
            parse_tab.Add((object)110, (object)"<s_stm_list>".ToString(), new Action_Record(Action.Shift, 111));
            parse_tab.Add((object)110, (object)"this".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)110, (object)"while".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)110, (object)"if".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)110, (object)"for".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)110, (object)"read".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)110, (object)"print".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)110, (object)"ID".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)110, (object)"}".ToString(), new Action_Record(Action.Reduce, 90));
            //Item Set 111
            parse_tab.Add((object)111, (object)"}".ToString(), new Action_Record(Action.Shift, 149));
            parse_tab.Add((object)111, (object)"<st_stm>".ToString(), new Action_Record(Action.Shift_Reduce, 89));
            parse_tab.Add((object)111, (object)"this".ToString(), new Action_Record(Action.Shift, 71));
            parse_tab.Add((object)111, (object)"while".ToString(), new Action_Record(Action.Shift, 72));
            parse_tab.Add((object)111, (object)"if".ToString(), new Action_Record(Action.Shift, 74));
            parse_tab.Add((object)111, (object)"for".ToString(), new Action_Record(Action.Shift, 73));
            parse_tab.Add((object)111, (object)"read".ToString(), new Action_Record(Action.Shift, 94));
            parse_tab.Add((object)111, (object)"print".ToString(), new Action_Record(Action.Shift, 95));
            parse_tab.Add((object)111, (object)"<lhs>".ToString(), new Action_Record(Action.Shift, 96));
            parse_tab.Add((object)111, (object)"ID".ToString(), new Action_Record(Action.Shift, 124));
            //Item Set 112
            parse_tab.Add((object)112, (object)"ID".ToString(), new Action_Record(Action.Shift, 113));
            //Item Set 113
            parse_tab.Add((object)113, (object)")".ToString(), new Action_Record(Action.Shift, 114));
            //Item Set 114
            parse_tab.Add((object)114, (object)";".ToString(), new Action_Record(Action.Shift_Reduce, 93));
            //Item Set 115
            parse_tab.Add((object)115, (object)";".ToString(), new Action_Record(Action.Shift_Reduce, 94));
            parse_tab.Add((object)115, (object)"<add_op>".ToString(), new Action_Record(Action.Shift, 102));
            parse_tab.Add((object)115, (object)"+".ToString(), new Action_Record(Action.Shift_Reduce, 73));
            parse_tab.Add((object)115, (object)"-".ToString(), new Action_Record(Action.Shift_Reduce, 74));            
            //Item Set 116
            parse_tab.Add((object)116, (object)";".ToString(), new Action_Record(Action.Reduce, 65));
            parse_tab.Add((object)116, (object)")".ToString(), new Action_Record(Action.Reduce, 65));
            parse_tab.Add((object)116, (object)"+".ToString(), new Action_Record(Action.Reduce, 65));
            parse_tab.Add((object)116, (object)"-".ToString(), new Action_Record(Action.Reduce, 65));

            parse_tab.Add((object)116, (object)"<mult_op>".ToString(), new Action_Record(Action.Shift, 105));
            parse_tab.Add((object)116, (object)"*".ToString(), new Action_Record(Action.Shift_Reduce, 75));
            parse_tab.Add((object)116, (object)"/".ToString(), new Action_Record(Action.Shift_Reduce, 76));            
            //Item Set 117
            parse_tab.Add((object)117, (object)"<last>".ToString(), new Action_Record(Action.Shift, 90));
            parse_tab.Add((object)117, (object)"ID".ToString(), new Action_Record(Action.Shift, 186));            
            //Item Set 118
            parse_tab.Add((object)118, (object)"<last>".ToString(), new Action_Record(Action.Shift, 166));
            parse_tab.Add((object)118, (object)"ID".ToString(), new Action_Record(Action.Shift, 167));            
            //Item Set 119
            parse_tab.Add((object)119, (object)"<s_stm_list>".ToString(), new Action_Record(Action.Shift, 65));
            parse_tab.Add((object)119, (object)"this".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)119, (object)"while".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)119, (object)"if".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)119, (object)"for".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)119, (object)"read".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)119, (object)"print".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)119, (object)"ID".ToString(), new Action_Record(Action.Reduce, 90));
            parse_tab.Add((object)119, (object)"}".ToString(), new Action_Record(Action.Reduce, 90));      
            //Item Set 120
            parse_tab.Add((object)120, (object)"<stm_list>".ToString(), new Action_Record(Action.Shift, 121));           
            parse_tab.Add((object)120, (object)"while".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)120, (object)"if".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)120, (object)"for".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)120, (object)"read".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)120, (object)"print".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)120, (object)"ID".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)120, (object)"}".ToString(), new Action_Record(Action.Reduce, 38));           
            //Item Set 121
            parse_tab.Add((object)121, (object)"}".ToString(), new Action_Record(Action.Shift_Reduce, 45));
            parse_tab.Add((object)121, (object)"<stm>".ToString(), new Action_Record(Action.Shift_Reduce, 37));
            parse_tab.Add((object)121, (object)"while".ToString(), new Action_Record(Action.Shift, 153));
            parse_tab.Add((object)121, (object)"for".ToString(), new Action_Record(Action.Shift, 135));
            parse_tab.Add((object)121, (object)"if".ToString(), new Action_Record(Action.Shift, 138));
            parse_tab.Add((object)121, (object)"read".ToString(), new Action_Record(Action.Shift, 136));
            parse_tab.Add((object)121, (object)"print".ToString(), new Action_Record(Action.Shift, 137));
            parse_tab.Add((object)121, (object)"ID".ToString(), new Action_Record(Action.Shift, 176));
            parse_tab.Add((object)121, (object)"<lhs>".ToString(), new Action_Record(Action.Shift, 133));
            //Item Set 122
            parse_tab.Add((object)122, (object)",".ToString(), new Action_Record(Action.Shift, 123));
            parse_tab.Add((object)122, (object)";".ToString(), new Action_Record(Action.Reduce, 117));
            //Item Set 123
            parse_tab.Add((object)123, (object)"ID".ToString(), new Action_Record(Action.Shift_Reduce, 119));
            //Item Set 124
            parse_tab.Add((object)124, (object)".".ToString(), new Action_Record(Action.Shift, 125));
            parse_tab.Add((object)124, (object)"=".ToString(), new Action_Record(Action.Reduce, 107));
            //Item Set 125
            parse_tab.Add((object)125, (object)"ID".ToString(), new Action_Record(Action.Shift, 126));
            //Item Set 126
            parse_tab.Add((object)126, (object)"(".ToString(), new Action_Record(Action.Shift, 127));
            parse_tab.Add((object)126, (object)"=".ToString(), new Action_Record(Action.Reduce, 108));
            //Item Set 127
            parse_tab.Add((object)127, (object)"<param_list>".ToString(), new Action_Record(Action.Shift, 130));
            parse_tab.Add((object)127, (object)"<params>".ToString(), new Action_Record(Action.Shift, 128));
            parse_tab.Add((object)127, (object)"<factor>".ToString(), new Action_Record(Action.Shift_Reduce, 111));
            parse_tab.Add((object)127, (object)")".ToString(), new Action_Record(Action.Reduce, 112));
            parse_tab.Add((object)127, (object)"ID".ToString(), new Action_Record(Action.Shift, 187));
            parse_tab.Add((object)127, (object)"LIT".ToString(), new Action_Record(Action.Shift_Reduce, 72));
            parse_tab.Add((object)127, (object)"(".ToString(), new Action_Record(Action.Shift, 104));
            
            //Item Set 128
            parse_tab.Add((object)128, (object)",".ToString(), new Action_Record(Action.Shift, 129));
            parse_tab.Add((object)128, (object)")".ToString(), new Action_Record(Action.Reduce, 109));
            //Item Set 129
            parse_tab.Add((object)129, (object)"<factor>".ToString(), new Action_Record(Action.Shift_Reduce, 110));
            parse_tab.Add((object)129, (object)"(".ToString(), new Action_Record(Action.Shift, 104));
            parse_tab.Add((object)129, (object)"ID".ToString(), new Action_Record(Action.Shift, 187));
            parse_tab.Add((object)129, (object)"LIT".ToString(), new Action_Record(Action.Shift_Reduce,72));
            //Item Set 130
            parse_tab.Add((object)130, (object)")".ToString(), new Action_Record(Action.Shift, 131));
            //Item Set 131
            parse_tab.Add((object)131, (object)";".ToString(), new Action_Record(Action.Shift_Reduce, 95));
            //Item Set 132
            parse_tab.Add((object)132, (object)"<stm>".ToString(), new Action_Record(Action.Shift_Reduce, 37));
            parse_tab.Add((object)132, (object)"}".ToString(), new Action_Record(Action.Reduce, 36));
            parse_tab.Add((object)132, (object)"<lhs>".ToString(), new Action_Record(Action.Shift, 133));
            parse_tab.Add((object)132, (object)"while".ToString(), new Action_Record(Action.Shift, 153));
            parse_tab.Add((object)132, (object)"if".ToString(), new Action_Record(Action.Shift, 138));
            parse_tab.Add((object)132, (object)"for".ToString(), new Action_Record(Action.Shift, 135));
            parse_tab.Add((object)132, (object)"read".ToString(), new Action_Record(Action.Shift, 136));
            parse_tab.Add((object)132, (object)"print".ToString(), new Action_Record(Action.Shift, 137));            
            parse_tab.Add((object)132, (object)"ID".ToString(), new Action_Record(Action.Shift, 176));
            //Item Set 133
            parse_tab.Add((object)133, (object)"=".ToString(), new Action_Record(Action.Shift, 134));
            //Item Set 134
            parse_tab.Add((object)134, (object)"<exp>".ToString(), new Action_Record(Action.Shift, 139));
            parse_tab.Add((object)134, (object)"<term>".ToString(), new Action_Record(Action.Shift,116));
            parse_tab.Add((object)134, (object)"<factor>".ToString(), new Action_Record(Action.Shift_Reduce, 67));
            parse_tab.Add((object)134, (object)"(".ToString(), new Action_Record(Action.Shift, 104));
            parse_tab.Add((object)134, (object)"ID".ToString(), new Action_Record(Action.Shift, 187));
            parse_tab.Add((object)134, (object)"LIT".ToString(), new Action_Record(Action.Shift_Reduce, 72));            
            //Item Set 135
            parse_tab.Add((object)135, (object)"(".ToString(), new Action_Record(Action.Shift, 159));
            //Item Set 136
            parse_tab.Add((object)136, (object)"(".ToString(), new Action_Record(Action.Shift, 140));            
            //Item Set 137
            parse_tab.Add((object)137, (object)"<exp>".ToString(), new Action_Record(Action.Shift, 143));
            parse_tab.Add((object)137, (object)"<term>".ToString(), new Action_Record(Action.Shift, 116));
            parse_tab.Add((object)137, (object)"<factor>".ToString(), new Action_Record(Action.Shift_Reduce, 67));
            parse_tab.Add((object)137, (object)"(".ToString(), new Action_Record(Action.Shift, 104));
            parse_tab.Add((object)137, (object)"ID".ToString(), new Action_Record(Action.Shift, 187));                        
            //Item Set 138
            parse_tab.Add((object)138, (object)"(".ToString(), new Action_Record(Action.Shift, 144));            
            //Item Set 139
            parse_tab.Add((object)139, (object)";".ToString(), new Action_Record(Action.Shift_Reduce, 39));
            parse_tab.Add((object)139, (object)"<add_op>".ToString(), new Action_Record(Action.Shift, 102));
            parse_tab.Add((object)139, (object)"+".ToString(), new Action_Record(Action.Shift_Reduce, 73));
            parse_tab.Add((object)139, (object)"-".ToString(), new Action_Record(Action.Shift_Reduce, 74));
            //Item Set 140
            parse_tab.Add((object)140, (object)"ID".ToString(), new Action_Record(Action.Shift, 141));
            //Item Set 141
            parse_tab.Add((object)141, (object)")".ToString(), new Action_Record(Action.Shift, 142));            
            //Item Set 142
            parse_tab.Add((object)142, (object)";".ToString(), new Action_Record(Action.Shift_Reduce, 40));
            //Item Set 143
            parse_tab.Add((object)143, (object)";".ToString(), new Action_Record(Action.Shift_Reduce, 41));
            parse_tab.Add((object)143, (object)"<add_op>".ToString(), new Action_Record(Action.Shift, 102));
            parse_tab.Add((object)143, (object)"+".ToString(), new Action_Record(Action.Shift_Reduce, 73));
            parse_tab.Add((object)143, (object)"-".ToString(), new Action_Record(Action.Shift_Reduce, 74));
            //Item Set 144
            parse_tab.Add((object)144, (object)"<rel_exp>".ToString(), new Action_Record(Action.Shift, 145));
            parse_tab.Add((object)144, (object)"<rel_term>".ToString(), new Action_Record(Action.Shift_Reduce, 51));
            parse_tab.Add((object)144, (object)"<rel_fac>".ToString(), new Action_Record(Action.Shift, 98));
            parse_tab.Add((object)144, (object)"ID".ToString(), new Action_Record(Action.Shift, 81));
            parse_tab.Add((object)144, (object)"LIT".ToString(), new Action_Record(Action.Shift_Reduce, 55));
            //Item Set 145
            parse_tab.Add((object)145, (object)")".ToString(), new Action_Record(Action.Shift, 146));
            parse_tab.Add((object)145, (object)"<rel_op>".ToString(), new Action_Record(Action.Shift, 97));
            parse_tab.Add((object)145, (object)"AND".ToString(), new Action_Record(Action.Shift_Reduce, 57));
            parse_tab.Add((object)145, (object)"OR".ToString(), new Action_Record(Action.Shift_Reduce, 58));
            //Item Set 146
            parse_tab.Add((object)146, (object)"{".ToString(), new Action_Record(Action.Shift, 147));
            //Item Set 147
            parse_tab.Add((object)147, (object)"<stm_list>".ToString(), new Action_Record(Action.Shift, 148));
            parse_tab.Add((object)147, (object)"}".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)147, (object)"while".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)147, (object)"if".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)147, (object)"for".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)147, (object)"read".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)147, (object)"print".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)147, (object)"ID".ToString(), new Action_Record(Action.Reduce, 38));            
            //Item Set 148
            parse_tab.Add((object)148, (object)"}".ToString(), new Action_Record(Action.Shift, 151));            
            parse_tab.Add((object)148, (object)"<stm>".ToString(), new Action_Record(Action.Shift_Reduce, 37));            
            parse_tab.Add((object)148, (object)"<lhs>".ToString(), new Action_Record(Action.Shift, 133));
            parse_tab.Add((object)148, (object)"while".ToString(), new Action_Record(Action.Shift, 153));
            parse_tab.Add((object)148, (object)"if".ToString(), new Action_Record(Action.Shift, 138));
            parse_tab.Add((object)148, (object)"for".ToString(), new Action_Record(Action.Shift, 135));
            parse_tab.Add((object)148, (object)"read".ToString(), new Action_Record(Action.Shift, 136));
            parse_tab.Add((object)148, (object)"print".ToString(), new Action_Record(Action.Shift, 137));
            parse_tab.Add((object)148, (object)"ID".ToString(), new Action_Record(Action.Shift, 176));
            //Item Set 149
            parse_tab.Add((object)149, (object)"<s_else>".ToString(), new Action_Record(Action.Shift_Reduce, 99));
            parse_tab.Add((object)149, (object)"else".ToString(), new Action_Record(Action.Shift, 150));
            parse_tab.Add((object)149, (object)"}".ToString(), new Action_Record(Action.Reduce, 101));                        
            parse_tab.Add((object)149, (object)"while".ToString(), new Action_Record(Action.Reduce, 101));
            parse_tab.Add((object)149, (object)"if".ToString(), new Action_Record(Action.Reduce, 101));
            parse_tab.Add((object)149, (object)"for".ToString(), new Action_Record(Action.Reduce, 101));
            parse_tab.Add((object)149, (object)"read".ToString(), new Action_Record(Action.Reduce, 101));
            parse_tab.Add((object)149, (object)"print".ToString(), new Action_Record(Action.Reduce, 101));
            parse_tab.Add((object)149, (object)"ID".ToString(), new Action_Record(Action.Reduce, 101));            
            //Item Set 150
            parse_tab.Add((object)150, (object)"{".ToString(), new Action_Record(Action.Shift, 119));
            //Item Set 151
            parse_tab.Add((object)151, (object)"<else>".ToString(), new Action_Record(Action.Shift_Reduce, 44));
            parse_tab.Add((object)151, (object)"else".ToString(), new Action_Record(Action.Shift, 152));
            parse_tab.Add((object)151, (object)"}".ToString(), new Action_Record(Action.Reduce, 46));
            parse_tab.Add((object)151, (object)"while".ToString(), new Action_Record(Action.Reduce, 46));
            parse_tab.Add((object)151, (object)"if".ToString(), new Action_Record(Action.Reduce, 46));
            parse_tab.Add((object)151, (object)"for".ToString(), new Action_Record(Action.Reduce, 46));
            parse_tab.Add((object)151, (object)"read".ToString(), new Action_Record(Action.Reduce, 46));
            parse_tab.Add((object)151, (object)"print".ToString(), new Action_Record(Action.Reduce, 46));
            parse_tab.Add((object)151, (object)"ID".ToString(), new Action_Record(Action.Reduce, 46));  
            //Item Set 152
            parse_tab.Add((object)152, (object)"{".ToString(), new Action_Record(Action.Shift, 120));  
            //Item Set 153
            parse_tab.Add((object)153, (object)"(".ToString(), new Action_Record(Action.Shift, 154));  
            //Item Set 154
            parse_tab.Add((object)154, (object)"<rel_exp>".ToString(), new Action_Record(Action.Shift, 155));
            parse_tab.Add((object)154, (object)"<rel_term>".ToString(), new Action_Record(Action.Shift_Reduce, 51));
            parse_tab.Add((object)154, (object)"<rel_fac>".ToString(), new Action_Record(Action.Shift, 98));
            parse_tab.Add((object)154, (object)"ID".ToString(), new Action_Record(Action.Shift, 81));
            parse_tab.Add((object)154, (object)"LIT".ToString(), new Action_Record(Action.Shift, 155)); 
            //Item Set 155
            parse_tab.Add((object)155, (object)")".ToString(), new Action_Record(Action.Shift, 156));
            parse_tab.Add((object)155, (object)"<rel_op>".ToString(), new Action_Record(Action.Shift, 97));
            parse_tab.Add((object)155, (object)"AND".ToString(), new Action_Record(Action.Shift, 57));
            parse_tab.Add((object)155, (object)"OR".ToString(), new Action_Record(Action.Shift, 58)); 
            //Item Set 156
            parse_tab.Add((object)156, (object)"{".ToString(), new Action_Record(Action.Shift, 157));
            //Item Set 157
            parse_tab.Add((object)157, (object)"<stm_list>".ToString(), new Action_Record(Action.Shift, 158));
            parse_tab.Add((object)157, (object)"}".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)157, (object)"while".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)157, (object)"if".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)157, (object)"for".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)157, (object)"read".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)157, (object)"print".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)157, (object)"ID".ToString(), new Action_Record(Action.Reduce, 38)); 
            //Item Set 158
            parse_tab.Add((object)158, (object)"}".ToString(), new Action_Record(Action.Shift_Reduce, 47));
            parse_tab.Add((object)158, (object)"<stm>".ToString(), new Action_Record(Action.Shift_Reduce, 37));            
            parse_tab.Add((object)158, (object)"<lhs>".ToString(), new Action_Record(Action.Shift, 133));
            parse_tab.Add((object)158, (object)"while".ToString(), new Action_Record(Action.Shift, 153));
            parse_tab.Add((object)158, (object)"if".ToString(), new Action_Record(Action.Shift, 138));
            parse_tab.Add((object)158, (object)"for".ToString(), new Action_Record(Action.Shift, 135));
            parse_tab.Add((object)158, (object)"read".ToString(), new Action_Record(Action.Shift, 136));
            parse_tab.Add((object)158, (object)"print".ToString(), new Action_Record(Action.Shift, 137));
            parse_tab.Add((object)158, (object)"ID".ToString(), new Action_Record(Action.Shift, 176));
            //Item Set 159
            parse_tab.Add((object)159, (object)"<init>".ToString(), new Action_Record(Action.Shift, 160));
            parse_tab.Add((object)159, (object)"ID".ToString(), new Action_Record(Action.Shift, 161));
            //Item Set 160
            parse_tab.Add((object)160, (object)"<mid>".ToString(), new Action_Record(Action.Shift, 164));
            parse_tab.Add((object)160, (object)"<rel_exp>".ToString(), new Action_Record(Action.Shift, 165));
            parse_tab.Add((object)160, (object)"<rel_term>".ToString(), new Action_Record(Action.Shift_Reduce, 51));
            parse_tab.Add((object)160, (object)"<rel_fac>".ToString(), new Action_Record(Action.Shift, 98));
            parse_tab.Add((object)160, (object)"ID".ToString(), new Action_Record(Action.Shift, 81));
            parse_tab.Add((object)160, (object)"LIT".ToString(), new Action_Record(Action.Shift_Reduce, 55));
            //Item Set 161
            parse_tab.Add((object)161, (object)"=".ToString(), new Action_Record(Action.Shift, 162));
            //Item Set 162
            parse_tab.Add((object)162, (object)"LIT".ToString(), new Action_Record(Action.Shift, 163));
            //Item Set 163
            parse_tab.Add((object)163, (object)";".ToString(), new Action_Record(Action.Shift_Reduce,102));
            //Item Set 164
            parse_tab.Add((object)164, (object)";".ToString(), new Action_Record(Action.Shift, 118));
            //Item Set 165
            parse_tab.Add((object)165, (object)";".ToString(), new Action_Record(Action.Reduce, 103));
            parse_tab.Add((object)165, (object)"<rel_op>".ToString(), new Action_Record(Action.Shift, 97));
            parse_tab.Add((object)165, (object)"AND".ToString(), new Action_Record(Action.Shift_Reduce,57));
            parse_tab.Add((object)165, (object)"OR".ToString(), new Action_Record(Action.Shift_Reduce, 58));
            //Item Set 166
            parse_tab.Add((object)166, (object)")".ToString(), new Action_Record(Action.Shift,168));
            //Item Set 167
            parse_tab.Add((object)167, (object)"<in_dec>".ToString(), new Action_Record(Action.Shift_Reduce, 104));            
            parse_tab.Add((object)167, (object)"++".ToString(), new Action_Record(Action.Shift_Reduce, 105));
            parse_tab.Add((object)167, (object)"--".ToString(), new Action_Record(Action.Shift_Reduce, 106));
            //Item Set 168
            parse_tab.Add((object)168, (object)"{".ToString(), new Action_Record(Action.Shift, 169));
            //Item Set 169
            parse_tab.Add((object)169, (object)"<stm_list>".ToString(), new Action_Record(Action.Shift, 170));
            parse_tab.Add((object)169, (object)"}".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)169, (object)"while".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)169, (object)"if".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)169, (object)"for".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)169, (object)"read".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)169, (object)"print".ToString(), new Action_Record(Action.Reduce, 38));
            parse_tab.Add((object)169, (object)"ID".ToString(), new Action_Record(Action.Reduce, 38)); 
            //Item Set 170
            parse_tab.Add((object)170, (object)"}".ToString(), new Action_Record(Action.Shift_Reduce, 48));
            parse_tab.Add((object)170, (object)"<stm>".ToString(), new Action_Record(Action.Shift_Reduce, 37));
            parse_tab.Add((object)170, (object)"<lhs>".ToString(), new Action_Record(Action.Shift, 133));
            parse_tab.Add((object)170, (object)"while".ToString(), new Action_Record(Action.Shift, 153));
            parse_tab.Add((object)170, (object)"if".ToString(), new Action_Record(Action.Shift, 138));
            parse_tab.Add((object)170, (object)"for".ToString(), new Action_Record(Action.Shift, 135));
            parse_tab.Add((object)170, (object)"read".ToString(), new Action_Record(Action.Shift, 136));
            parse_tab.Add((object)170, (object)"print".ToString(), new Action_Record(Action.Shift, 137));
            parse_tab.Add((object)170, (object)"ID".ToString(), new Action_Record(Action.Shift, 176));
            //Item Set 171
            parse_tab.Add((object)171, (object)")".ToString(), new Action_Record(Action.Shift_Reduce, 43));
            //Item Set 172
            parse_tab.Add((object)172, (object)"ID".ToString(), new Action_Record(Action.Look_Ahead, 173));            
            //Item Set 173
            parse_tab.Add((object)173, (object)"(".ToString(), new Action_Record(Action.Reduce, 29));
            parse_tab.Add((object)173, (object)",".ToString(), new Action_Record(Action.Shift_Reduce, 125));
            parse_tab.Add((object)173, (object)";".ToString(), new Action_Record(Action.Shift_Reduce, 125));
            parse_tab.Add((object)173, (object)"=".ToString(), new Action_Record(Action.Shift_Reduce, 125));
            //Item Set 174
            parse_tab.Add((object)174, (object)";".ToString(), new Action_Record(Action.Shift_Reduce, 122));
            //Item Set 175
            parse_tab.Add((object)175, (object)"<vd_rest>".ToString(), new Action_Record(Action.Shift_Reduce,124 ));
            parse_tab.Add((object)175, (object)"<vd_simple>".ToString(), new Action_Record(Action.Shift,122 ));
            parse_tab.Add((object)175, (object)"<vd_new>".ToString(), new Action_Record(Action.Shift_Reduce,118 ));
            parse_tab.Add((object)175, (object)",".ToString(), new Action_Record(Action.Reduce,120 ));
            parse_tab.Add((object)175, (object)";".ToString(), new Action_Record(Action.Reduce,120 ));
            parse_tab.Add((object)175, (object)"=".ToString(), new Action_Record(Action.Shift,19 ));

        
            //Item Set 176
            parse_tab.Add((object)176, (object)".".ToString(), new Action_Record(Action.Shift, 177));                
            parse_tab.Add((object)176, (object)"=".ToString(), new Action_Record(Action.Reduce, 107));              
            //Item Set 177
            parse_tab.Add((object)177, (object)"ID".ToString(), new Action_Record(Action.Shift, 178));              
            //Item Set 178
            parse_tab.Add((object)178, (object)"(".ToString(), new Action_Record(Action.Shift, 179));             
            parse_tab.Add((object)178, (object)"=".ToString(), new Action_Record(Action.Reduce, 107));             
            //Item Set 179
            parse_tab.Add((object)179, (object)"<param_list>".ToString(), new Action_Record(Action.Shift, 181));         
            parse_tab.Add((object)179, (object)"<params>".ToString(), new Action_Record(Action.Shift, 128));              
            parse_tab.Add((object)179, (object)"<factor>".ToString(), new Action_Record(Action.Shift_Reduce, 111));       
            parse_tab.Add((object)179, (object)")".ToString(), new Action_Record(Action.Reduce, 112));                   
            parse_tab.Add((object)179, (object)"LIT".ToString(), new Action_Record(Action.Shift_Reduce, 72));            
            parse_tab.Add((object)179, (object)"ID".ToString(), new Action_Record(Action.Shift, 187)); 
            //Item Set 182----removed
            //Item Set 180
            parse_tab.Add((object)180, (object)"<factor>".ToString(), new Action_Record(Action.Shift_Reduce, 110));       
            //Item Set 181
            parse_tab.Add((object)181, (object)")".ToString(), new Action_Record(Action.Shift, 182));                    
            //Item Set 182
            parse_tab.Add((object)182, (object)";".ToString(), new Action_Record(Action.Shift_Reduce, 42));              
            //Item Set 183
            parse_tab.Add((object)183, (object)"=".ToString(), new Action_Record(Action.Shift, 184));                  
            //Item Set 184
            parse_tab.Add((object)184, (object)"LIT".ToString(), new Action_Record(Action.Shift, 185));                
            //Item Set 185
            parse_tab.Add((object)185, (object)";".ToString(), new Action_Record(Action.Shift_Reduce, 102));             
            //Item Set 186
            parse_tab.Add((object)186, (object)"<in_dec>".ToString(), new Action_Record(Action.Shift_Reduce, 104));      
            parse_tab.Add((object)186, (object)"++".ToString(), new Action_Record(Action.Shift_Reduce, 105));            
            parse_tab.Add((object)186, (object)"--".ToString(), new Action_Record(Action.Shift_Reduce, 106));             
            //Item Set 187
            parse_tab.Add((object)187, (object)".".ToString(), new Action_Record(Action.Shift, 188));                     
            parse_tab.Add((object)187, (object)"*".ToString(), new Action_Record(Action.Reduce, 70));                    
            parse_tab.Add((object)187, (object)"/".ToString(), new Action_Record(Action.Reduce, 70));                     
            parse_tab.Add((object)187, (object)";".ToString(), new Action_Record(Action.Reduce, 70));                    
            parse_tab.Add((object)187, (object)"+".ToString(), new Action_Record(Action.Reduce, 70));                     
            parse_tab.Add((object)187, (object)"-".ToString(), new Action_Record(Action.Reduce, 70));                    
            parse_tab.Add((object)187, (object)")".ToString(), new Action_Record(Action.Reduce, 70));                    
            parse_tab.Add((object)187, (object)"'".ToString(), new Action_Record(Action.Reduce, 70));                     
            //Item Set 188
            parse_tab.Add((object)188, (object)"ID".ToString(), new Action_Record(Action.Shift_Reduce, 71));              
     
            //Item Set 189
            parse_tab.Add((object)189, (object)"<stm>".ToString(), new Action_Record(Action.Shift_Reduce, 37));           
            parse_tab.Add((object)189, (object)"}".ToString(), new Action_Record(Action.Shift_Reduce, 45));                  
            parse_tab.Add((object)189, (object)"<lhs>".ToString(), new Action_Record(Action.Shift, 133));                
            parse_tab.Add((object)189, (object)"while".ToString(), new Action_Record(Action.Shift, 153));                 
            parse_tab.Add((object)189, (object)"if".ToString(), new Action_Record(Action.Shift, 138));                     
            parse_tab.Add((object)189, (object)"for".ToString(), new Action_Record(Action.Shift, 135));                    
            parse_tab.Add((object)189, (object)"read".ToString(), new Action_Record(Action.Shift, 136));                    
            parse_tab.Add((object)189, (object)"print".ToString(), new Action_Record(Action.Shift, 137));                   
            parse_tab.Add((object)189, (object)"ID".ToString(), new Action_Record(Action.Shift, 176));                     
            
            //Item Set 190
            parse_tab.Add((object)190, (object)"int".ToString(), new Action_Record(Action.Look_Ahead, 191));                
            parse_tab.Add((object)190, (object)"string".ToString(), new Action_Record(Action.Look_Ahead, 191));             
            parse_tab.Add((object)190, (object)"ID".ToString(), new Action_Record(Action.Look_Ahead, 192));                 
            //Item Set 191            
            parse_tab.Add((object)191, (object)"ID".ToString(), new Action_Record(Action.Look_Ahead, 192));                 
            //Item Set 192
            parse_tab.Add((object)192, (object)";".ToString(), new Action_Record(Action.Shift_Reduce, 27));                 
            parse_tab.Add((object)192, (object)",".ToString(), new Action_Record(Action.Shift_Reduce, 27));                
            parse_tab.Add((object)192, (object)"=".ToString(), new Action_Record(Action.Shift_Reduce, 27));             
            parse_tab.Add((object)192, (object)"(".ToString(), new Action_Record(Action.Reduce, 23));         
            
                   
            
            
            
        }
        
    }
    
    
    


    
}
