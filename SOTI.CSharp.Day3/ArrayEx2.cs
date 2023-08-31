using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day3
{
    internal class ArrayEx2
    {
        static void Main1(string[] args)
        {
            string[,] strArr = new string[2, 3];
            strArr[0, 0] = "Row 1";
            strArr[1, 0] = "Row 2";

            int[,] arr = new int[2, 3];

            Console.WriteLine($"First Dimension Size :{arr.GetLength(0)}");
            Console.WriteLine($"Second Dimension Size :{arr.GetLength(1)}");

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine($"Row is {i + 1}");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("Ente a Number :");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"arr[{i},{j}] = {arr[i, j]}");
                }
                Console.WriteLine();
            }

            //One-dimension Array
            //int[] one = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(string.Join(", ", one));
            //string name = "PRoduct";
            //char[] ch = name.ToCharArray();
            //foreach(int x in one)
            //{
            //    Console.Write(x);
            //    Console.Write(", ");
            //}


        }
    }
}
