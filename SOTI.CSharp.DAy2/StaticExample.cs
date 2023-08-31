using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.DAy2
{
    public class Customer1
    {
        public int customerId;
        public string customerName;
        public static int count;

        //To initialize static variable
        static Customer1()
        {
            Console.WriteLine("Static Constructor");
            count = 1000;
        }

        public Customer1()
        {
            Console.WriteLine("Instance Constructor");
            //count = 1;
            customerId = ++count;
            customerName = string.Empty;
        }

        //To manipulate static variable
        public static int CalculateCustomersOnline()
        {
            return count - 1000;
        }

        public void Display()
        {
            Console.WriteLine($"Customer Id :{customerId}");
        }

        static void Main1(string[] args)
        {
            Customer1 one = new Customer1();
            Customer1 two = new Customer1();
            Customer1 three = new Customer1();

            one.Display();
            two.Display();
            three.Display();

            Console.WriteLine("Total :" + Customer1.CalculateCustomersOnline());

        }
    }
}
