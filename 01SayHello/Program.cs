using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SayHello
{
    class SayHello
    {
        static void Main()
        {
            AskForName();
        }

        public static void AskForName()
        {
            string input = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", input);
        }
    }
}
