using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace SOTI.CSharp.Day6
{
    //Create a Delegate - 1
    public delegate void CalculateDelegate(int num1, int num2);
    public delegate int MyDelegate(string name, string city);
    public delegate double DiscountDelegate(double amount);

    internal class Program
    {
        public event CalculateDelegate myCalculate;
        public void AddNumber(int a, int b)
        {
            Console.WriteLine($"Sum :{a + b}");
        }

        public void MultiNumber(int a, int b)
        {
            Console.WriteLine($"Product :{a * b}");
        }

        public void DivideNumber(int a, int b)
        {
            Console.WriteLine($"Divide :{a / b}");
        }

        public int GetData(string empName, string empCity)
        {
            if (string.IsNullOrWhiteSpace(empName) || string.IsNullOrEmpty(empCity))
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        //public double NewyearDiscount(double amount)
        //{
        //    return amount - (amount * 0.2);
        //}

        public void Initialize()
        {
            //Instantiate a Delegate - 2
            //CalculateDelegate del = new CalculateDelegate(AddNumber); 
            //CalculateDelegate del = AddNumber;

            ////Use a Delegate  - 3
            //del(50, 60);

            //Multicast 
            CalculateDelegate del = AddNumber;
            del += MultiNumber;
            del += AddNumber;
            del += DivideNumber;
            //  del -= AddNumber;
            del(20, 5);

            //DiscountDelegate discount = NewyearDiscount;
            //var result = discount(2000);
            //Console.WriteLine($"After Discount :{result}");

            //Anonymous Method using Delegate
            DiscountDelegate discount = delegate (double amount)
                {
                    return amount - (amount * 0.2);
                };

            var result = discount(2000);
            Console.WriteLine($"New Year Discount :{result}");

            DiscountDelegate birthDayDiscount = delegate (double amount)
            {
                return amount - (amount * 0.25);
            };

            var result1 = birthDayDiscount(2500);
            Console.WriteLine($"Birthday Discount :{result1}");

            //Anonymous Method using Lambda Expression
            DiscountDelegate pongalDiscount = (double amount) =>
            {
                return amount - (amount * 0.25);
            };

            var result2 = pongalDiscount(2500);
            Console.WriteLine($"Customer 1 Pongal Discount :{result1}");

            var c2 = pongalDiscount(5000);
            Console.WriteLine($"Customer 2 Pongal Discount :{c2}");
        }

        static void Main1(string[] args)
        {
            Program p = new Program();
            p.Initialize();

            //CalculateDelegate calculate = p.AddNumber;
            //calculate(10, 20);
        }
    }
}
