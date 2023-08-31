using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.ProductLibrary
{
    internal class ChildClass : AccessSpecifierEx
    {
        public void GetData()
        {
            base.ProductId = 1001;
            base.ProductName = "Lpatop";
            base.Price = 5000;
            base.Quantity = 100;
            //base.PrivateData = 111 ;
        }
    }
}
