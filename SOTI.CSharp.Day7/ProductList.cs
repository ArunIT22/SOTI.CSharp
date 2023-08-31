using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day7
{
    public class ProductList
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product{ Id =1, Name ="Pen", Price=50},
                new Product{ Id =2, Name ="Water Bottle", Price=9000},
                new Product{ Id =3, Name ="Table Clock", Price=90},
                new Product{ Id =4, Name ="Laptop", Price=50000},
            };
        }

        public void DisplayProduct(List<Product> products)
        {
            Console.WriteLine("ProductId\tProduct Name\t\tPrice");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id,-10}\t{product.Name,-20}\t{product.Price}");
            }
        }

        static void Main1(string[] args)
        {
            ProductList productList = new ProductList();
            var products = productList.GetProducts();
            // products.Sort();

            var sortByName = products.OrderByDescending(p => p.Name).ThenBy(c=>c.Price).ToList();

            //restrict columns
            var prd1 = products.Select(p => new
            {
                ProductName = p.Name,
                ProductPrice = p.Price
            }).ToList();

            //search by id
            var oneProduct = products.FirstOrDefault(p => p.Id == 1);

           // var customer = new { Id = 1001, Name = "Kumar", City = "Chennai" };

            //var query = (from prd in products
            //            where prd.Name == "Laptop"
            //            select prd).ToList();
            ////Console.WriteLine($"Product Id :{query");
            //var searchedProduct = new List<Product>();

            //foreach (var item in products)
            //{
            //    if (item.Name == "Laptop")
            //    {
            //        searchedProduct.Add(item);
            //    }
            //}
           
             //productList.DisplayProduct();
        }
    }
}
