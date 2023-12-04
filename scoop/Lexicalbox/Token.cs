using System;

namespace scoop
{
    public class Token
    {

        private ClassPart classPart;
        private String valuePart;
        private int lineNumber;
        private int colNumber;

        public Token(ClassPart classPart, String valuePart)
        {
            this.classPart = classPart;
            this.valuePart = valuePart;
        }

        public ClassPart getClassPart()
        {
            return classPart;
        }

        public void setClassPart(ClassPart classPart)
        {
            this.classPart = classPart;
        }

        public String getValuePart()
        {
            return valuePart;
        }

        public void setValuePart(String valuePart)
        {
            this.valuePart = valuePart;
        }

        public int getColNumber()
        {
            return colNumber;
        }

        public void setColNumber(int colNumber)
        {
            this.colNumber = colNumber;
        }

        public int getLineNumber()
        {
            return lineNumber;
        }

        public void setLineNumber(int lineNumber)
        {
            this.lineNumber = lineNumber;
        }


    }
}
