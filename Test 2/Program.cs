using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberElement;
            Console.WriteLine("Please input number of elements in square matrix :");
            numberElement = Convert.ToByte(Console.ReadLine());

            int num1 = 0;
            int num2 = 0;

            int[][] array = new int[numberElement][];

            for (int i = 0; i < numberElement; i++)
            {
                Console.WriteLine("Please input array {0} : (ex: 1 2 3)",i+1);
                array[i] = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
                num1 += array[i][i];
                num2 += array[i][numberElement - 1 - i];
            }

            Console.WriteLine("Diagonal Difference : {0}", Math.Abs(num1-num2));
            Console.ReadKey();
        }
    }
}