using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.ProductLibrary
{
    internal class ExecuteClass
    {
        public void AddData()
        {
            AccessSpecifierEx obj = new AccessSpecifierEx();
            obj.ProductId = 10001;
           //obj.ProductName = "Laptop";
            obj.Price = 50000;
            obj.Quantity = 200;
        }
    }
}
