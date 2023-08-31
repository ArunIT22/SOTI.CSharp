using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day8
{
    public class Example4
    {
        public void Method1(object obj)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} Printing, Thread Id :{Thread.CurrentThread.ManagedThreadId}, " +
                $"Priority :{Thread.CurrentThread.Priority}");
               // $"Thread Pool :{Thread.CurrentThread.IsThreadPoolThread}");
        }

        public void Method2(object obj)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} Printing, Thread Id :{Thread.CurrentThread.ManagedThreadId}, " +
                 $"Priority :{Thread.CurrentThread.Priority}");
            //$"Thread Pool :{Thread.CurrentThread.IsThreadPoolThread}");
        }

        public void Method3(object obj)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} Printing, Thread Id :{Thread.CurrentThread.ManagedThreadId}," +
                 $"Priority :{Thread.CurrentThread.Priority}");
            //$"Thread Pool :{Thread.CurrentThread.IsThreadPoolThread}");
        }

        static void Main(string[] args)
        {
            Example4 obj = new Example4();
            Thread t1 = new Thread(obj.Method1)
            {
                Name = "Method 1",
                Priority = ThreadPriority.Lowest
            };

            Thread t2 = new Thread(obj.Method2)
            {
                Name = "Method 2",
                Priority = ThreadPriority.Highest
            };

            Thread t3 = new Thread(obj.Method3)
            {
                Name = "Method 3",
                Priority = ThreadPriority.BelowNormal
            };

            t1.Start();
            t2.Start();
            t3.Start();

            //ThreadPool.QueueUserWorkItem(new WaitCallback(obj.Method1));
            //ThreadPool.QueueUserWorkItem(new WaitCallback(obj.Method2));
            //ThreadPool.QueueUserWorkItem(new WaitCallback(obj.Method3));
        }
    }
}
