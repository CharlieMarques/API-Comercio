namespace API_Comercio.Models.Domain
{
    public class ProductPurchase : Product
    {
        public  Supplier Supplier { get; set; } = new Supplier();
        public int Amount { get; set; }  
        public float Cost {  get; set; }
    }
}
