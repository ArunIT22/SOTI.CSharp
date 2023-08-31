using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day5
{
    //public sealed class Parent
    //{

    //}

    //public class Child : Parent
    //{

    //}

    public abstract class Customer : ITax
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public abstract void GetCustomerDetails();
        public abstract string DisplayCustomerDetails();
        public abstract double GetDiscount();

        public void Test()
        {
            Console.WriteLine("Parent Test Method");
        }

        public virtual void AnotherMethod()
        {
            Console.WriteLine("Another Method");
        }

        public virtual double PayTax()
        {
            return 0;
        }

        public double PayDifferentTax()
        {
            throw new NotImplementedException();
        }
    }

    public class PriveledgedCustomer : Customer, ITax
    {
        public double Coupons { get; set; }
        public override void GetCustomerDetails()
        {
            Console.Write("Enter Customer Id :");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Customer Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Mobile No :");
            MobileNo = Console.ReadLine();
            Console.WriteLine("Enter No of Coupons :");
            Coupons = float.Parse(Console.ReadLine());
        }

        public override string DisplayCustomerDetails()
        {
            return $"Customer Id :{Id}\nName :{Name}\nMobile No:{MobileNo}\nCoupons :{Coupons}";
        }

        public override double GetDiscount()
        {
            return 0.5;
        }
    }

    public class RegularCustomer : Customer
    {
        public float DiscountPercentage { get; set; }
        public override string DisplayCustomerDetails()
        {
            return $"Customer Id :{Id}\nName :{Name}\nMobile No:{MobileNo}\nDiscount Percentage :{DiscountPercentage}";
        }

        public override void GetCustomerDetails()
        {
            Console.Write("Enter Customer Id :");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Customer Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Mobile No :");
            MobileNo = Console.ReadLine();
            Console.WriteLine("Enter Discount :");
            DiscountPercentage = float.Parse(Console.ReadLine());
        }

        public override double GetDiscount()
        {
            return 0.2;
        }
    }

    public class Bill
    {

        public double Calculate(Customer customer, double billAmount)
        {
            double totalBill = 0;
            //if (customer is PriveledgedCustomer)
            //{
            //    Console.WriteLine("Hello, Priveledged Customer");
            //    customer.GetCustomerDetails();
            //    totalBill = billAmount - (billAmount * customer.GetDiscount());
            //}
            //else if (customer is RegularCustomer)
            //{
            //    Console.WriteLine("Hello, Regular Customer");
            //    customer.GetCustomerDetails();
            //    totalBill = billAmount - (billAmount * customer.GetDiscount());
            //}
            customer.GetCustomerDetails();
            totalBill = billAmount - (billAmount * customer.GetDiscount());
            return totalBill;
        }

        static void Main1(string[] args)
        {
            PriveledgedCustomer priveledged = new PriveledgedCustomer();
            // priveledged.GetCustomerDetails();

            RegularCustomer regular = new RegularCustomer();
            //regular.GetCustomerDetails();

            EliteCustomer elite = new EliteCustomer();

            Bill obj = new Bill();
            obj.Calculate(regular, 1000);

        }
    }
}
