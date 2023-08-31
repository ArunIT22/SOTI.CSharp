using System;
using static System.Console;
using SOTI.ProductLibrary;

namespace SOTI.CSharp.Day1
{
    class Program
    {
        static void Main()
        {
            #region Product Example
            //int id; string name; double price;
            //Product product = new Product();
            ////product.ProductId = 1;
            ////product.ProductName = "Laptop";
            ////product.Price = 5000;
            ////string result = product.DisplayProduct();
            ////WriteLine(result);
            ////WriteLine("-----------------");
            ////Calling GetProduct
            //Write("Enter Id: ");
            //id = int.Parse(ReadLine());
            //Write("Enter Product Name :");
            //name = ReadLine();
            //Write("Enter Price :");
            //price = double.Parse(ReadLine());
            //Write("Enter a Float Value");
            //float sal = float.Parse(ReadLine());
            //WriteLine($"Float Value :{sal}");

            //product.GetProduct(id, name, price);
            //string result = product.DisplayProduct();
            //WriteLine(result);
            //ReadKey();
            #endregion

            Assignment1 a1 = new Assignment1();
            double result = a1.CalculateCostPerPerson(12, 65, 96);
            WriteLine(result);
        }
    }
}
