namespace API_Comercio.Models
{
    public class Purchase
    {
        public List<ProductPurchase> PurchaseProducts { get; set; } = new List<ProductPurchase>();
        public Supplier Supplier { get; set; } = new Supplier();
        public DateTime? Date { get; set; }

    }
}
