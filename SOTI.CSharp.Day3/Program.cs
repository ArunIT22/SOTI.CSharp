using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOTI.ProductLibrary;

namespace SOTI.CSharp.Day3
{
    internal class Program : AccessSpecifierEx
    {
        public void GetParent()
        {
            ProductId = 1;
            base.ProductName = "Box";
            //base.Price = 6000;
            base.Quantity = 200;
        }
        static void Main1(string[] args)
        {
            AccessSpecifierEx obj = new AccessSpecifierEx();
            obj.ProductId = 20001;
            //obj.ProductName = "Pen";
            //obj.Price = 6000;
            
        }
    }
}
