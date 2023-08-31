using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day4
{
    public class ProductClass
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public ProductClass()
        {
            Id = 1001;
        }

        public ProductClass(int id)
        {
            this.Id = id;
        }

        public ProductClass(string productName, double price, int quantity) : this()
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        public ProductClass(int id, string productName, double price, int quantity) : this(productName, price, quantity)
        {
            Id = id;
            //ProductName = productName;
            //Price = price;
            //Quantity = quantity;
        }

        public void UpdateProduct(double price)
        {
            Price = price;
        }

        public void UpdateProduct(int quantity)
        {
            Quantity = quantity;
        }

        public void UpdateProduct(double price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        public void Display()
        {
            Console.WriteLine("Product Id\tProduct Name\tPrice\t\tQuantity");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"{Id,-15}\t{ProductName,-10}\t{Price,-8}\t{Quantity}");
        }

        static void Main1(string[] args)
        {
            ProductClass obj1 = new ProductClass();
            obj1.Display();
            Console.WriteLine();

            ProductClass obj2 = new ProductClass("Mobile Phone", 85000, 10);
            Console.WriteLine($"Id :{obj2.Id}\tName :{obj2.ProductName}\tPrice :{obj2.Price}\tQuantity :{obj2.Quantity}");
            Console.WriteLine();

            ProductClass obj = new ProductClass(1002, "Laptop", 60000, 5);
            obj.Display();

            //Console.WriteLine();
            //obj.UpdateProduct(65000, 10);
            //obj.Display();
        }
    }
}
