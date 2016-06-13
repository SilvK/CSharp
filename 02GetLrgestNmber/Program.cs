using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
        var input = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

        Console.WriteLine(GetMax(input[0], GetMax(input[1], input[2]))); 

        }
         static int GetMax(int a, int b)
    {
        int maxNumber = a;
        if (b > a)
        {
            maxNumber = b;
        }
        return maxNumber;

    }
}
