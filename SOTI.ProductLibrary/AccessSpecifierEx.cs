namespace SOTI.ProductLibrary
{
    public class AccessSpecifierEx
    {
        public int ProductId { get; set; }
        protected string ProductName { get; set; }
        internal decimal Price { get; set; }
        protected internal int Quantity { get; set; }
    }
}
