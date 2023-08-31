using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day5
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent Class Constructor");
        }

        public ParentClass(string name):this()
        {
            Console.WriteLine("Parent Class " + name);
        }

        ~ParentClass()
        {
            Console.WriteLine("Parent Class Destructor");
        }
    }

    public class ChildClass1 : ParentClass
    {
        public ChildClass1() : base("From Child")
        {
            Console.WriteLine("Child Class 1 Constructor");
        }

        ~ChildClass1()
        {
            Console.WriteLine("Child Class 1 Destructor");
        }
    }

    public class ExecuteClass
    {
        static void Main1(string[] args)
        {
            ChildClass1 childClass1 = new ChildClass1();
        }
    }
}
