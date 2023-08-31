using System;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day9
{
    //SingletonPattern
    public sealed class Singleton
    {
        public static int counter = 0;

        private static readonly object lockObject = new object();

        //Step 2 - Private static variable which returns object the class
        private static Singleton _singleton = null;

        //Step 3 - Create a Property or Method which return the object to the private static variable
        public static Singleton GetInstance
        {
            get
            {
                if (_singleton == null)
                {
                    lock (lockObject)
                    {
                        if (_singleton == null)
                        {
                            _singleton = new Singleton();
                        }
                    }
                }
                return _singleton;
            }
        }

        //public static Singleton Instance()
        //{
        //    if (_singleton == null)
        //    {
        //        _singleton = new Singleton();
        //    }
        //    return _singleton;
        //}

        //Step 1 - Creating Private Constructor, does not allow user to create object directly
        private Singleton()
        {
            counter++;
        }

        public void Print(string name)
        {
            Console.WriteLine($"Counter :{counter}");
            Console.WriteLine(name);
        }

        ////Nested Class
        //public class ChildClass : Singleton
        //{

        //}
    }

    public class ExecuteClass
    {
        private static void Method1()
        {
            Singleton obj1 = Singleton.GetInstance;
            obj1.Print("This is Object 1");
        }

        private static void Method2()
        {
            Singleton obj2 = Singleton.GetInstance;
            obj2.Print("This is Object 2");
        }

        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => Method1(),
                () => Method2());

            Console.ReadKey();
        }


    }

}
