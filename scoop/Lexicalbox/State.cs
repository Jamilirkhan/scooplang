using System;
using System.Collections;

namespace scoop
{
    public class State
    {

        private bool initial;
        private bool final;
        private String name;
        private Hashtable transitionTable;
        private StateAction action;

        public State(String name, bool initial, bool final)
        {
            this.name = name;
            this.initial = initial;
            this.final = final;
            transitionTable = new Hashtable();
        }

        public bool isFinal()
        {
            return final;
        }

        public void setFinal(bool final)
        {
            this.final = final;
        }

        public bool isInitial()
        {
            return initial;
        }

        public void setInitial(bool initial)
        {
            this.initial = initial;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void addTransition(String input, State state)
        {
            transitionTable[input] = state;
        }

        public State getNextState(String input)
        {
            return (State)transitionTable[input];
        }

        public void setAction(StateAction action)
        {
            this.action += action;
        }

        public Token getToken(String lexeme)
        {
            if (this.action != null)
            {
                return this.action(lexeme);
            }
            else
            {
                return null;
            }
        }

    }
}
