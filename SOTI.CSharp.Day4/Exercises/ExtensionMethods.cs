namespace SOTI.CSharp.Day4.Exercises
{
    public static class BillExtension
    {
        public static double CalculateServiceTax(this Bill obj, double totalAmount)
        {
            double tax;
            if (totalAmount < 2000)
            {
                tax = totalAmount;
            }
            else if (totalAmount >= 2000 && totalAmount <= 5000)
            {
                tax = totalAmount + (totalAmount * 0.02);
            }
            else
            {
                tax = totalAmount + (totalAmount * 0.05);
            }
            return tax;
        }
    }
}
