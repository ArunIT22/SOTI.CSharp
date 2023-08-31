using System;
using System.Runtime.InteropServices;
using static System.Console;

namespace SOTI.CSharp.Day3
{
    internal class ParameterTypes
    {
        public int AddNumber(int a, int b, ref int c)
        {
            a = ++c;
            a = b + c;
            c = a + b;
            return c;
        }

        public int MultiNumber(int a, int b, out int c)
        {
            c = a * b;
            //a = ++c;
            return a;
        }


        public void Test1(int[] arr)
        {
            foreach (int i in arr)
            {
                WriteLine(i);
            }
        }
        //Params
        public void Test2(int a, int b, params int[] arr)
        {
            foreach (int i in arr)
            {
                WriteLine(i);
            }
        }

        //Named Parameter
        public void GetData(int id, string name, double salary = 5000)
        {
            Console.WriteLine($"Id :{id}\tName :{name}\tSalary :{salary}");
        }

        static void Main1(string[] args)
        {
            ParameterTypes obj = new ParameterTypes();
            int x = 10, y = 20, z;

            //  int res = obj.AddNumber(x, y, ref z);

            int res = obj.MultiNumber(x, y, out z);

            WriteLine($"Result :{res}");

            WriteLine($"Z :{z}");

            //int.TryParse(ReadLine(), out int num1);
            //WriteLine(num1);

            obj.Test1(new int[] { 1, 2, 3, 4, 5 });
            WriteLine();
            obj.Test2(a: 10, b: 20, 1, 2, 3, 4, 5, 6, 7);

            //Calling Named Parameter
            obj.GetData(salary: 8000, id: 101, name: "Lokesh");
            obj.GetData(name: "Sanjay", id: 102);
        }
    }
}
