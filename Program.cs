using System;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace AnimationExample
{
    class Program
    {
        public static async Task Main(string[] args)
        {

            const string msg = "Hola todo el mundo soy un grandioso programador, tengo 23 años de edad y me apasiona lo que hago.";
            for (int i = 0; i < msg.Length; i++)
            {
                // a kind of an animation
                Console.WriteLine(msg.Substring(0, i + 1));
                await Task.Delay(100);
            }

            Console.WriteLine("Done!");
            await Task.Delay(0);
        }  
    }
}
