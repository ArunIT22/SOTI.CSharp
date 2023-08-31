using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SOTI.CSharp.Day4
{
    internal class Product : IDisposable
    {
        public int? Id { get; set; }
        public string ProductName { get; set; }
        public double? Price { get; set; }
        public DateTime? ActualDeliveryDate { get; set; }

        public Product()
        {
            Id = 1001;
            Id = null;
            Price = null;
            if (Price.HasValue)
            {
                Console.WriteLine(Price.Value);
            }
            ActualDeliveryDate = null;

        }

        ~Product() { }

        public void Dispose()
        {
            GC.SuppressFinalize(this);//Disbale Finalize method
        }
    }
}
