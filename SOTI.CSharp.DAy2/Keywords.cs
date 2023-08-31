using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.DAy2
{
    internal class Keywords
    {
        //const
        //readonly

        public const double price = 5000.5;
        public readonly double salary = 50000;

        public Keywords()
        {
            salary = 60000;
        }

        public void ChangeData()
        {
            // price = 6000;
            //salary = 60000;
        }

        static void Main1(string[] args)
        {
            //Keywords.price = 6000;
            Console.WriteLine($"Constant Price :{Keywords.price}");
            Keywords obj = new Keywords();
            //obj.salary = 4000;
            Console.WriteLine($"Readonly :{obj.salary}");
        }
    }
}
