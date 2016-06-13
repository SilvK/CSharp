using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    class Program
    {
        static int Parse(string number) //signatura
        {
            int result = 0;
            foreach (char digit in number)
            {
                result = (digit - '0') + result * 10;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Parse("253"));
        }
    }
}
