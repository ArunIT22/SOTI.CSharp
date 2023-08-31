using System;
using System.Linq;
using System.Collections;

namespace SOTI.CSharp.Day7
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            ArrayList list = new ArrayList() { 50, 60, 1, 5, -9 };
            //list.Add(100);
            //list.Add("string");
            //list.Add(true);
            //list.Add(88800.66M);
            // list.Add(new Product { Id = 1001, Name = "Mobiles" });

            //list.Insert(0, 1000);

            // list.Remove(1);

            Console.WriteLine("Clone");

            var cloneList = (ArrayList)list.Clone();
            cloneList.Insert(4, 5000);
            var arr = cloneList;

            // list.Sort();
            foreach (object i in arr)
            {
                Console.WriteLine(i);
            }

            //Console.WriteLine();

            ////Collection Initializer
            //ArrayList list2 = new ArrayList() { 100, "string", true, 5000.6 };
            //foreach (object i in list2)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("\nHash Table Example\n");

            ////HashTable
            //Hashtable ht = new Hashtable();
            //ht.Add(1, "ABc");
            //ht.Add(2, "Xya");
            //ht.Add(3, 1000);
            //ht[4] = "Collection Intializer";

            //if (ht.ContainsKey(5))
            //    Console.WriteLine(ht[5]);
            //else
            //    Console.WriteLine("No Key exists");

            //foreach (DictionaryEntry i in ht)
            //{
            //    Console.WriteLine(i.Value);
            //}
        }
    }
}
