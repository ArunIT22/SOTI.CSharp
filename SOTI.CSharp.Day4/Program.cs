using SOTI.CSharp.Day4.Exercises;
using System;
using System.IO;

namespace SOTI.CSharp.Day4
{
    internal class Program
    {
        private Product _product = null;       

        public Program()
        {
            _product = new Product();
        }

        public void Test()
        {
            try
            {
                try
                {
                    _product = new Product();
                    _product.Id = 1001;
                }
                catch
                {
                    Console.WriteLine("Error");
                }

                int a = 10, b = 0, c = 0;
                c = a / b;
                int[] arr = new int[4];
                arr[4] = 100;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                //if( _product != null )
                //{
                //    _product.Dispose();
                //}
                _product?.Dispose();
            }
            Console.WriteLine("Try catch handled");
        }

        public void GetProduct()
        {
            Console.WriteLine("Enter Id :");
            _product.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Name :");
            _product.ProductName = Console.ReadLine();
            Console.WriteLine("Enter Price :");
            _product.Price = double.Parse(Console.ReadLine());
            if (_product.Price <= 0)
            {
                throw new PriceCannotBeZeroException("Price cannot be less than zero");
            }
        }

        static void Main1(string[] args)
        {
            #region Bill
            //Restuarant restuarant = new Restuarant();
            //var result = restuarant.CalculateAmount(new Bill { BillId = 1, Price = 500, Quantity = 5 });
            //Console.WriteLine($"Total Bill Amount :{result}");
            #endregion

            #region Program


            //Program p = new Program();
            //try
            //{
            //    p.GetProduct();
            //}
            //catch (NullReferenceException) { }
            //catch (PriceCannotBeZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            var a = 100;
            // a = "ABC";
            var x = "asdasd";
            var v1 = new Program();
            var v2 = new Product();
            Console.WriteLine(v2.ProductName);
            //   var v3;

            //dynamic
            dynamic a1 = 100;
            a1 = "XYZ";
            Console.WriteLine(a1);
            a1 = new Product() { ProductName = "Laptop" };
            Console.WriteLine(a1.ProductName);
            // dynamic d1;
            //
        }
    }
}
