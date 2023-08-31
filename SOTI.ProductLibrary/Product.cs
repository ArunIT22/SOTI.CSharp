namespace SOTI.ProductLibrary
{
    public class Product
    {
        //Member Variable
        public int ProductId;
        public string ProductName;
        public double Price;

        public void GetProduct(int productId, string productName, double price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }

        public string DisplayProduct()
        {
            return $"Product Id:{ProductId}\nProduct Name :{ProductName}\nPrice :{Price}";
        }
    }
}
