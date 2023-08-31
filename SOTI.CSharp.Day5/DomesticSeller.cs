using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day5
{
    public abstract class Seller
    {
        public int Id { get; set; }
        public string SellerName { get; set; }
        public string Location { get; set; }
    }


    public class DomesticSeller : Seller, ITax, IStateTax
    {
        public bool ExpressDelivery { get; set; }

        public double PayDifferentTax()
        {
            throw new NotImplementedException();
        }

        //IMplicit Interface Declaration
        //public double PayTax()
        //{
        //    return 0.5;
        //}

        //Explicit Interface Declaration
        double ITax.PayTax()
        {
            return 0.5;
        }

        double IStateTax.PayTax()
        {
            return 0.2;
        }

        double TestMethod()
        {
            return 0;
        }
    }

    public class InternationalSeller : Seller, ITax, IStateTax
    {
        public double ExportCharges { get; set; }

        public double PayDifferentTax()
        {
            throw new NotImplementedException();
        }

        public double PayTax()
        {
            return 0.2;
        }
    }

    public class Retailer : IStateTax
    {
        public double PayTax()
        {
            return 0.6;
        }
    }

    public class MainClass
    {
        static void Main(string[] args)
        {
            ITax central = new DomesticSeller();
            Console.WriteLine($"Central Tax :{central.PayTax()}");
            
            IStateTax state = new DomesticSeller();
            Console.WriteLine($"State Tax :{state.PayTax()}");

            DomesticSeller seller = new DomesticSeller();
            Console.WriteLine(((ITax)seller).PayTax());
            Console.WriteLine(((IStateTax)seller).PayTax());

        }
    }
}
