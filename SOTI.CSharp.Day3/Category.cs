using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day3
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class Products
    {
        public void GetProducts(Category[] categories)
        {
            foreach (Category category in categories)
            {
                Console.WriteLine($"Id :{category.Id}\tName :{category.Name}");
            }
        }

        static void Main1(string[] args)
        {
            Products p = new Products();
            Console.Write("Size :");
            int size = int.Parse(Console.ReadLine());
            Category[] categories = new Category[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Category Id :");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Enter Category Name :");
                string name = Console.ReadLine();
                categories[i] = new Category { Id = id, Name = name };
                //categories[i] = new Category();
                //categories[i].Id = id;
                //categories[i].Name = name;
            }

            //Call Get Products Method
            p.GetProducts(categories);
        }
    }
}
