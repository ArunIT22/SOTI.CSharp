using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day7
{
    internal class GenericCollection
    {
        static void Main1(string[] args)
        {
            List<int> list = new List<int>(3);
            list.Add(100);
            list.Add(100);
            list.Add(100);
            list.Add(100);

            list.Sort();

            list.Insert(2, 5000);

            list.Remove(100);

            list.RemoveAt(0);

            //Console.WriteLine($"Capcity :{list.Capacity}");
            //Console.WriteLine($"Count :{list.Count}");

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            Dictionary<int, string> obj = new Dictionary<int, string>();
            obj[1] = "Chennai";
            obj[2] = "Mumbai";
            obj[3] = "Delhi";

            //foreach (KeyValuePair<int, string> o in obj)
            //{
            //    Console.WriteLine($"Key :{o.Key}\tValue :{o.Value}");
            //}

            //HashSet<int> set = new HashSet<int>() { 1, 2, 3, 3, 3, 4, 4, 5, 5, 6, 7 };

            //foreach (var item in set)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
