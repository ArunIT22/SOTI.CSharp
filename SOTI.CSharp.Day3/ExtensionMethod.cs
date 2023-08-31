using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day3
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }

        public void GetEmployee()
        {
            Console.WriteLine("Enter Id :");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name :");
            Name = Console.ReadLine();
        }

        public void DisplayEmployee()
        {
            Console.WriteLine($"Id :{Id}\nName :{Name}");
            MobileNo.WordCount();
        }
    }

    public class ExecuteClass
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            // emp.GetEmployee();
            //emp.DisplayEmployee();
            bool res = emp.ValidateMobileNo("7894561203");
            if(res)
            {
                Console.WriteLine("Valid Mobile No");
            }
            else
            {
                Console.WriteLine("Invalid Mobile no");
            }

            //string data
            string data = "Today is a wonderful day sdf sdf sdf";
            Console.WriteLine($"No. of Words :{data.WordCount()}");
        }


    }

    public static class ExtensionMethod
    {
        public static bool ValidateMobileNo(this Employee emp, string mobileNo)
        {
            //Console.WriteLine("Validating Mobile No");
            if (mobileNo.Length == 10)
                return true;
            else
                return false;
        }

        public static int WordCount(this string str)
        {
            return str.Split(' ').Length;
        }

    }
}
