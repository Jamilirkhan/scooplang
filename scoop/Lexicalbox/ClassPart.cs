using System;

namespace scoop
{

    public enum ClassPart
    {

        ID,		//identifier
        DT,		//datatype
        LP,		//left paranthesis (
        RP,		//right paranthesis )
        LB,		//left bracket {
        RB,		//right bracket }
        SC,		//semi colon ;
        COL,    //colon
        FOR,	//for
        REL_OP,	//relational operator > < >= <= == !=
        LIT,	//literal
        INC_DEC_OP,	//increment operator ++, --        
        ARIT_OP,//arithmatic operator  - 
        plus_op,//plus operator +
        mul_op,//multiplication operator  *
        div_op,//division operator   /
        minus_op,//minus operator   -
        EQ_OP,	//equal operator =
        IF,		//if
        ELSE,	//else
        KW,     //Keyword or reserved word
        Seprator,
        COMMA,	//comma ,        
        LSB,    //left square bracket
        RSB,    //right square bracket
        LOG_OP, //logical operator   AND, OR
        SCOPE,  //scope words   public, private
        DOT,    //dot   .
        EOF     //end of file
        
    }
}
