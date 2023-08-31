namespace SOTI.CSharp.Day4.Exercises
{
    public class Restuarant
    {
        public Restuarant()
        {
            
        }

        public double CalculateAmount(Bill billObj)
        {
            double total = billObj.Price * billObj.Quantity;
            return billObj.CalculateServiceTax(total);
        }
    }
}
