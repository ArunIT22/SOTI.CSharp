using SOTI.CSharp.Day8SOLID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day8SOLID
{
    public partial class PartialClassDemo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void GetData()
        {
            Console.WriteLine("Get Method");
        }

        partial void TestMethod();

    }

    partial class PartialClassDemo
    {
        public void Print()
        {
            Console.WriteLine("Print Method");
        }
    }

    partial class PartialClassDemo
    {
        partial void TestMethod()
        {
            Console.WriteLine("Partial Method");
        }
    }
}

public class Execute
{
    static void Main(string[] args)
    {
        PartialClassDemo obj = new PartialClassDemo();
        obj.GetData();
        obj.Print();
    }
}
