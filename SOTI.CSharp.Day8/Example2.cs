using System;
using System.Threading;

namespace SOTI.CSharp.Day8
{
    public class Example2
    {
        public static int StaticCounter = 0;
        public int NonStaticCounter = 0;
        private static object myObject = new object();

        public static void StaticMethod()
        {
            for (int i = 0; i < 1000000; i++)
            {
                //lock (myObject)
                //{
                //    StaticCounter++;
                //}

                Interlocked.Increment(ref StaticCounter);
            }
        }

        public void NonStaticMethod()
        {
            for (int i = 0; i < 1000000; i++)
            {
                //lock (this)
                //{
                //    NonStaticCounter++;
                //}
                Interlocked.Increment(ref NonStaticCounter);
            }
        }

        static void Main1(string[] args)
        {
            Example2 obj1 = new Example2();
            Example2 obj2 = new Example2();


            Thread t2 = new Thread(Example2.StaticMethod);
            Thread t4 = new Thread(Example2.StaticMethod);

            Thread t1 = new Thread(obj1.NonStaticMethod);
            Thread t3 = new Thread(obj1.NonStaticMethod);

            t1.Start();//Non Static
            t2.Start();//Static
            t3.Start();//Non Static
            t4.Start();//Static

            //Finishes all the thread
            t1.Join();
            //t2.Join();
            //t3.Join();
            //t4.Join();

            Console.WriteLine($"Static Counter :{Example2.StaticCounter}");
            Console.WriteLine($"Non Static Counter :{obj1.NonStaticCounter}");
            // Console.WriteLine($"Non Static Counter :{obj2.NonStaticCounter}");

        }
    }
}
