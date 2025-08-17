namespace API_Comercio.Models
{
    public class ProductSale : Product
    {
        public int Amount { get; set; }
        public float ProfitPercentage {  get; set; }
    }
}
