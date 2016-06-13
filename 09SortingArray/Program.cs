using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            SortArray(arrayOfNumbers);
            Console.WriteLine(string.Join(" ", arrayOfNumbers));
        }

        static void SortArray(int[] array)
        {
            Array.Sort(array);
        }
    }
}
