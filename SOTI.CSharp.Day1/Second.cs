using SOTI.ProductLibrary;
using System;
using System.Text;
using static System.Console;

namespace SOTI.CSharp.Day1
{
    internal class Second
    {
        static void Main1(string[] args)
        {
            //Boxing - Converting Value type to Reference Type
            //Reference Type
            //Implicit Boxing
            decimal d = 50000.66m;
            object objDecimal = d;
            int X = 100;
            int Y = 200;
            objDecimal = X + Y;

            //String - Immutable
            string str = "ABC";
            str += "XYZ";
            int num1 = 1000;
            //Explicit Boxing
            str = num1.ToString();
            str = d.ToString();
            num1 = 2000;

            //UnBoxing - Converting Reference Type to value type
            //Conversion Method or Parse Method
            decimal salary = Convert.ToDecimal(true);
            // decimal salary1 = decimal.Parse()

            //Typecasting - Converting Higher Type to Lower Type(Value to Value) or (Reference to Reference)
            int int1 = 1000;
            decimal d1 = int1;
            decimal d2 = 5000;
            int1 = (int)d2;
            long l1 = 12121212121122121;
            int x1 = checked((int)l1);
            WriteLine(x1);


            object obj2 = "Hello World";
            string str2 = (string)obj2;

            
        }
    }
}
