namespace API_Comercio.Models.Domain
{
    public class Purchase
    {
        public List<ProductPurchase> PurchaseProducts { get; set; } = new List<ProductPurchase>();
        public Supplier Supplier { get; set; } = new Supplier();
        public DateTime? Date { get; set; }

    }
}
