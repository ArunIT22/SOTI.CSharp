using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day3
{
    internal class Ex2
    {
        public static int[] ElementA(int[] input1, int input2)
        {
            int[] result = new int[input1.Length];
            int a = 0;
            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i] < input2)
                {
                    result[a] = input1[i];
                    a++;
                }
            }
            return result;
        }

        static void Main1(string[] args)
        {
            int[] result = ElementA(new int[] { 1, 4, 7, 3, 9, 15, 24 }, 10);
            Array.Sort(result);
            Array.Reverse(result);
            foreach (int i in result)
            {
                if (i != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
