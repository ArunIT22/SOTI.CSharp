using System;

namespace SOTI.CSharp.Day5
{
    public class Customer1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public double Price { get; set; }

        public virtual void GetCustomerDetails()
        {
            Console.Write("Enter Customer Id :");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Customer Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Mobile No :");
            MobileNo = Console.ReadLine();
            Console.WriteLine("Enter the Price :");
            Price = double.Parse(Console.ReadLine());
        }

        public virtual string DisplayCustomerDetails()
        {
            return $"Customer Id :{Id}\nName :{Name}\nMobile No:{MobileNo}\nPrice :{Price}\n";
        }

        public virtual void Test()
        {
            Console.WriteLine("Parent Method");
        }
    }

    public class EliteCustomer : Customer1
    {
        public int Coupons { get; set; }

        public override void Test()
        {
            Console.WriteLine("Child Method");
        }

        public override void GetCustomerDetails()
        {
            base.GetCustomerDetails();
            Console.WriteLine("Coupons :");
            Coupons = int.Parse(Console.ReadLine());
        }

        public override string DisplayCustomerDetails()
        {
            var parent = base.DisplayCustomerDetails();
            return parent += $"Coupons :{Coupons}";
        }

        public virtual double CalculateDiscount()
        {
            return Price - Coupons;
        }
    }

    public class RegularCustomer1 : Customer1
    {
        public float DiscountPercentage { get; set; }

        public override void GetCustomerDetails()
        {
            base.GetCustomerDetails();
            Console.WriteLine("Enter Discount Percentage :");
            DiscountPercentage = float.Parse(Console.ReadLine());
        }

        public override string DisplayCustomerDetails()
        {
            var parent = base.DisplayCustomerDetails();
            return parent += $"Discount Percentage :{DiscountPercentage}";
        }
    }

    class Execute
    {
        static void Main1(string[] args)
        {
            EliteCustomer elite = new EliteCustomer();
           
            //elite.GetCustomerDetails();
            //var output = elite.DisplayCustomerDetails();
            //Console.WriteLine(output);
            //var finalPrice = elite.CalculateDiscount();
            //Console.WriteLine($"Final Price :{finalPrice}");

            //Parent Reference
            Customer1 c = new EliteCustomer();            
            c.Test();
        }
    }
}
