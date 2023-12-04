using System;
using System.Collections;

namespace scoop
{
    public class DFA
    {

        State initialState;
        State currentState;
        State lastFinal;
        int lineNumber = 1;
        int colNumber = 1;

        public DFA(State initialState)
        {
            this.initialState = initialState;
            this.currentState = initialState;
        }

        public void reset()
        {
            this.currentState = initialState;
            this.lastFinal = null;
        }

        public ArrayList run(String str) {
		
		ArrayList tokens = new ArrayList();
        Token eof = new Token(ClassPart.EOF, "$$");

		int lastSuccessfullIndex = -1;
		int lastFinalIndex = -1;        

		for(int i=0;i<str.Length;i++) {
			currentState = currentState.getNextState("" + str[i]);			
			if(currentState==null) {				
				if(lastFinal != null) {
                    int startingIndex = lastSuccessfullIndex+1;
                    int length = lastFinalIndex - startingIndex + 1;
					String lexeme = str.Substring(startingIndex, length);
					Token token = lastFinal.getToken(lexeme);
					if(token!=null) {
						token.setLineNumber(lineNumber);
                        
						token.setColNumber(colNumber - lexeme.Length);
						System.Console.WriteLine("Line: " + token.getLineNumber() + ", Col: " + token.getColNumber() + ", Token: [" + token.getClassPart() + ", " + token.getValuePart() + "]");
						tokens.Add(token);
					} else {
                        int count = lexeme.Split('\n').Length - 1;
                        if(count > 0) {
						    lineNumber += count;
						    colNumber = 0;
						}
						
					}
					lastSuccessfullIndex = lastFinalIndex;
					i = lastFinalIndex;					
				} else {
					lastSuccessfullIndex = i;
					System.Console.WriteLine("Error at Line: " + lineNumber + ", Col: " + colNumber + ", \"" + str[lastFinalIndex+1] + "\"");
				}				
				reset();
			} else {
				
				if(currentState.isFinal()) {
					lastFinal = currentState;
					lastFinalIndex = i;
				}
								
			}
			colNumber ++;
		}            
       
        tokens.Add(eof);
		return tokens;
		
	}

    }
}
