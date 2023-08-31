using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.DAy2
{
    internal class Demo1
    {
        //Property Initializer
        public int Id { get; set; } = 1;
        public string Name { get; set; } = "Default";
        public double Salary { get; set; }

        public void Get(Demo1 demo)
        {
            Console.WriteLine(demo);
        }
        
        public override string ToString()
        {
            return $"Id :{Id}\tName :{Name}\tSalary :{Salary}";
        }

        static void Main(string[] args)
        {
            Demo1 obj = new Demo1();
            obj.Id = 1;
            obj.Name = "test";
            obj.Salary = 8000;

            //Object Initializer
            Demo1 obj2 = new Demo1()
            {
                Id = 2,
                Name = "test",
                Salary = 9000
            };
            obj.Get(new Demo1 { Id = 3, Name = "Test2", Salary = 6000 });
        }
    }
}
