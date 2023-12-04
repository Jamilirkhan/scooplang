using System;
using System.IO;
using System.Collections;

namespace scoop
{
    class TestScoop
    {
        static void Main(string[] args)
        {
            String source = "";

            try
            {
                StreamReader sr = new StreamReader("source.txt");//the source.txt file should be in the path    <ProjectFolder>/bin/debug/source.txt
                source = sr.ReadToEnd();

            //Performing Lexical Analysis
            LexicalBox lexicalBox = new LexicalBox();
            ArrayList tokens = lexicalBox.analyze(source);

            //Performing Syntax Analysis
            Parser parser = new Parser(tokens);

            parser.parse();
            Console.ReadKey();

            }
            catch (IOException e)
            {
                Console.WriteLine("The required 'source.txt' file is not found in the folder of the application");
                Console.ReadKey();
               
            }

            
        }
    }
}
