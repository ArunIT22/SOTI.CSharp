using System;
using static System.Console;

namespace SOTI.CSharp.DAy2
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Customer def = new Customer();            
            Customer c1 = new Customer(1001, "Pradeep", CardType.Platinum);
            def = c1;
            
            def.DisplayCustomer();
            c1.DisplayCustomer();
            WriteLine($"Card Type {CardType.Platinum} value : {(int)CardType.Platinum}");

            //var a1 = Enum.GetValues(typeof(CardType));
        }
    }

    struct Employee
    {
        public string name;
        public double salary;
        public char gender;

        public void SetValue()
        {
            name = "Test1";
            salary = 500;
            gender = 'A';
        }

        //public Employee(string nm, double sal, char g)
        //{
        //    name = nm;
        //    salary = sal;
        //    gender = g;
        //}

        static void Main1(string[] args)
        {
            Employee emp = new Employee();
            WriteLine("Set Value");
            emp.SetValue();
            //emp.name = "Aravind";
            //emp.salary = 50000;
            //emp.gender = 'M';

            WriteLine($"Name :{emp.name}\tSalary :{emp.salary}\tGender :{emp.gender}");
        }
    }
}
