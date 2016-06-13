using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06FirstLargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int [] numbersList = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            Console.WriteLine(LargerThanNeighboursInList(numbersList));
        }

        static int LargerThanNeighboursInList (int [] numbersList)
        {
            for (int i = 1; i < numbersList.Length-1; i++)
            {
                int currentNumber = numbersList[i];
                if (numbersList[i - 1] < currentNumber && currentNumber > numbersList[i + 1])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
