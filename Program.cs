using System;
using System.Linq;
using System.Text;

namespace CorreosSplit
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string correos = "Eddimir@dovinet.com;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;Edd@dovinet.com;" +
            "veloz@veloz.com;;hola.com;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;klkdimeave.com;;;" +
            ";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;";

            //string result = String.Join(";",correos.Split(';')
            //.Where(x=> !string.IsNullOrEmpty(x)).ToArray());
            //Console.WriteLine(result);
            string respuesta = SpecialRemoveSpacesOrCharterFromEmail(correos, ';');

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

