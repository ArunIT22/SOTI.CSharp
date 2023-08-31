namespace SOTI.CSharp.Day4.Exercises
{
    public class Bill
    {
        public int BillId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Bill()
        {
            
        }

        public Bill(int billId, double price, int quantity)
        {
            BillId = billId;
            Price = price;
            Quantity = quantity;
        }
    }
}
