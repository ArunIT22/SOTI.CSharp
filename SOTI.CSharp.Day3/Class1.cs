using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOTI.ProductLibrary;

namespace SOTI.CSharp.Day3
{
    internal class Class1 :AccessSpecifierEx
    {
        public void GetData()
        {
            base.Quantity = 33;
            AccessSpecifierEx obj = new AccessSpecifierEx();
            //obj.Quantity = 1;
        }
    }
}
