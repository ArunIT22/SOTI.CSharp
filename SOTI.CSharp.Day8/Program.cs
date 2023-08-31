using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SOTI.CSharp.Day8
{
    internal class Program
    {
        public void WriteA()
        {
            for (int i = 0; i < 1000; i++)
            {
                //Thread.Sleep(200);
                Console.Write("A");
            }
        }

        public void WriteB()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("B");
            }
        }

        static void Main1(string[] args)
        {
            Program p = new Program();
            Thread t1 = new Thread(new ThreadStart(p.WriteA));
            Thread t2 = new Thread(p.WriteB);

            //p.WriteA();
            //p.WriteB();

            t1.Start();
            t2.Start();

            Console.WriteLine("Main method ends here");
        }
    }
}
