using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day8
{
    internal class Example3
    {
        public int SumNumbers()
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += i;
            }
            return sum;
        }

        public int Multi(int a, int b)
        {
            //Thread.Sleep(5000);
            return a * b;
        }

        //public void ThreadCallMethod()
        //{
        //    Console.WriteLine();
        //}

        static void Main1(string[] args)
        {
            Console.WriteLine("Main Starts");
            Example3 obj = new Example3();
            int result = 0;
            int multiResult = 0;
            Thread t1 = new Thread(() => { result = obj.SumNumbers(); });
            Thread t2 = new Thread(() => { multiResult = obj.Multi(10, 5); });
            t1.Start();
            t2.Start();

            t1.Join();
            Console.WriteLine($"Sum Result :{result}");

            //t2.Join();
            Console.WriteLine($"Multi Result :{multiResult}");
        }
    }
}
