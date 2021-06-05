using System;
using System.Linq;
using System.Text;

namespace CorreosSplit
{
    public class Program
    {
        static void Main(string[] args)
        {
            string emails = "example@example.com;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;example2@example2.com;" +
            "example3@example3.com;;example4@example4.com;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;example5@example5.com;;;" +
            ";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;";
            
            //response as analysed, in this case by semicolon 
            //This exercise is for the purpose of the entry to be emails represented in string as our variable emails
            string response = SpecialRemoveSpacesOrCharterFromEmail(emails, ';');

            Console.WriteLine(respuesta);
        }

        public static string SpecialRemoveSpacesOrCharterFromEmail(String desc, Char crt)
        {
            StringBuilder builder = new StringBuilder();
            var result = (desc.Count(x => x == '@') <= desc.Count(c => c == crt));
            if (result)
            {
                for (int i = 0, n = 0; i < desc.Length; i++)
                {
                    if (desc[i] == ';')
                    {
                        n += 1;
                        if (n == 1)
                        {
                            builder.Append(desc[i]);
                        }
                    }
                    else
                    {
                        n = 0;
                        builder.Append(desc[i]);
                    }

                }
        
            }
            return builder.ToString();
        }
    }
}

