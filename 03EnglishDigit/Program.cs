using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03EnglishDigit
{
    class Program
    { //Write a method that returns the last 
        //digit of given integer as an English word. Write a program that reads a number and prints the result of the method.
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(LastDigitAsWord(number));
        }

        static string LastDigitAsWord (int number)
        {
            string digitAsWord = null;
            int lastDigit = number % 10;
            switch (lastDigit)
            {
                case 0: digitAsWord="zero"; break;
                case 1:digitAsWord="one"; break;
                case 2:digitAsWord="two"; break;
                case 3:digitAsWord="three"; break;
                case 4:digitAsWord="four"; break;
                case 5:digitAsWord="five"; break;
                case 6:digitAsWord="six"; break;
                case 7:digitAsWord="seven"; break;
                case 8:digitAsWord="eight"; break;
                case 9: digitAsWord="nine"; break;
                default: throw new ArgumentException();
                    break;
            }
            return digitAsWord;
        }
    }
}
