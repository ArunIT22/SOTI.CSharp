using System;

namespace SOTI.CSharp.Day4
{
    public class PriceCannotBeZeroException : ApplicationException
    {
        //public PriceCannotBeZeroException() : base()
        //{

        //}

        public PriceCannotBeZeroException(string msg) : base(msg)
        {

        }
    }
}
