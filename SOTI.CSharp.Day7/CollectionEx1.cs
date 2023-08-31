using System;
using System.Collections;
using System.Collections.Generic;

namespace SOTI.CSharp.Day7
{
    public class CollectionEx1
    {
        ArrayList list = null;

        public CollectionEx1()
        {
            list = new ArrayList();
        }
        static void Main1(string[] args)
        {
            //ArrayList list = new ArrayList();
            //list.Add(new Product { Id = 1, Name = "Water Bottle", Price = 500 });
            //list.Add(new Product { Id = 2, Name = "Hp Laptop", Price = 60000 });
            //list.Add(new Product { Id = 3, Name = "Macbook Pro", Price = 160000 });
            //list.Add(new Customer { Id = 1, Name = "Karthick", MobileNo = "7777777" });
            //list.Add(new Customer { Id = 2, Name = "Kayal", MobileNo = "66666" });
            //list.Add(new Customer { Id = 3, Name = "Bathri", MobileNo = "999999" });
            //list.Add(1000);

            //foreach (object item in list)
            //{
            //    //Product product = (Product)item;
            //    //Console.WriteLine($"Product Id :{product.Id}\tProduct Name :{product.Name}\tPrice :{product.Price}");

            //    if (item is Product)
            //    {
            //        Product product = (Product)item;
            //        Console.WriteLine($"Product Id :{product.Id}\tProduct Name :{product.Name}\tPrice :{product.Price}");
            //    }
            //    else if (item is Customer)
            //    {
            //        Customer customer = (Customer)item;
            //        Console.WriteLine($"Customer Id :{customer.Id}\tCustomer Name :{customer.Name}\tMobile No :{customer.MobileNo}");
            //    }
            //}

            CollectionEx1 c = new CollectionEx1();
            //do
            //{

            //}while(true);
            //

        }

        public ArrayList GetCustomers(Customer obj)
        {
            list.Add(obj);
            return list;
        }

        public void DisplayCustomer(ArrayList list)
        {
            if (list != null)
            {
                foreach (var item in list)
                {
                    if (item is Customer)
                    {
                        Customer customer = (Customer)item;
                        Console.WriteLine($"Customer Id :{customer.Id}\tCustomer Name :{customer.Name}\tMobile No :{customer.MobileNo}");
                    }
                }
            }
            else
            {
                Console.WriteLine("List is Empty.");
            }
        }

        public void RemoveCustomer(int customerId)
        {
            if (list != null)
            {
                foreach (var item in list)
                {
                    if (item is Customer)
                    {
                        Customer customer = (Customer)item;
                        if(customer.Id == customerId)
                        {
                            list.Remove(customer);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("List is Empty.");
            }
        }
    }
}
