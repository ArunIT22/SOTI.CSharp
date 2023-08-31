using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day5
{
    public interface ITax
    {
        double PayTax();
        double PayDifferentTax();
    }

    public interface IStateTax
    {
        double PayTax();
    }

    //Interface Inheritance
    public interface I1
    {
        void AddNumbers(int a, int b);
    }

    public interface I2
    {
        void Multi(int a, int b);
    }

    public interface I3 :I2, I1
    {
        void Divide(int a, int b);
    }


    public class TestClass : I3
    {
        public void AddNumbers(int a, int b)
        {
            throw new NotImplementedException();
        }

        public void Divide(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Multi(int a, int b)
        {
            throw new NotImplementedException();
        }
    }


    public abstract class Ab1
    {
        public abstract void Test1();
    }

    public abstract class Ab2 : Ab1
    {

    }
}
