using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day3
{
    public class ArrayEx
    {
        static void Main1(string[] args)
        {
            //One-dimension Array
            int[] arr;//Declare an array
            arr = new int[5];//Initializing an array

            int[] arr1 = new int[6];

            int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };

            int[] arr3 = { 2, 3, 4, 5 };

            Console.WriteLine("Using For Loop");
            //for loop
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            Console.WriteLine("\nUsing ForEach");
            //foreach
            foreach (int item in arr3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //Accept value from user
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter a Number :");
                arr[i] = int.Parse(Console.ReadLine());
            }
            //Sort - Quick Sort
            Array.Sort(arr);
            //Reverse
            Array.Reverse(arr);
            //Copy
            //arr1 = arr;
            Array.Copy(arr, 0, arr1, 0, 5);
            Array.Resize(ref arr1, 8);

            Console.WriteLine("\nPrint Arr1");
            foreach (int x in arr1)
            {
                Console.WriteLine(x);
            }
        }
    }
}
