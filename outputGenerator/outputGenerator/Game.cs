using System;
using System.Collections.Generic;
using System.Text;

namespace outputGenerator
{
    class Game
    {
        private string type;

        public Game()
        {
            type = " ";
        }

        public Game(string s)
        {
            type = s;
        }

       private String GenerateType(int level)
        {
            String datatype = " ";
            int choices = 0;
            Random randi = new Random(DateTime.Now.Millisecond);
            
            try
            {
                choices = randi.Next() % level;
            }
            catch(DivideByZeroException)
            {
                choices = 1;
            }

            switch (choices)
            {
                case 0:
                    datatype = "int";
                    break;
                case 1:
                    datatype = "char";
                    break;
                case 2:
                    datatype = "double";
                    break;
                case 3:
                    datatype = "string";
                    break;
                default:
                    datatype = "blank";
                    break;
            }

            return GenerateValues(datatype);
        }

       private String GenerateValues(String datatype)
        {
            Random randi;

            if (datatype == "int")
            {
                int val;
                int amount = 20;
                randi = new Random(DateTime.Now.Millisecond);
                val = randi.Next() % amount;

                return Convert.ToString(val);
            }
            else if (datatype == "char")
            {
                int beta;
                string[] alpha =
                {
                    "'a'","'b'","'c'","'d'","'e'","'f'",
                    "'l'","'k'","'j'","'i'","'h'","'g'",
                    "'m'","'n'","'o'","'p'","'q'","'r'",
                    "'x'","'w'","'v'","'u'","'t'","'s'",
                    "'y'","'z'"
                };
                randi = new Random();
                beta = randi.Next(alpha.Length);
                return alpha[beta];
            }
            else if (datatype == "double")
            {
                double val;
                double amount = 20.0;
                randi = new Random(DateTime.Now.Millisecond);
                val = randi.NextDouble() % amount;
                amount--;
                return Convert.ToString(Math.Round(val,3));
            }
            else if (datatype == "string")
            {
                int diction;
                string[] lexicon =
                {
                    "\"roof\"", "\"ruff\"", "\"meow\"", "\"door\"", "\"wall\"",
                    "\"cat\"", "\"dog\"", "\"rat\"", "\"pack\"", "\"mat\"",
                    "\"lamp\"", "\"pig\"", "\"moo\""
                };
                randi = new Random(DateTime.Now.Millisecond);
                diction = randi.Next(lexicon.Length);
                return lexicon[diction];
            }
            else
            {
                return " ";
            }
       }
        public string setValue(int level)
        {
            return GenerateType(level);
        }
    }
}
