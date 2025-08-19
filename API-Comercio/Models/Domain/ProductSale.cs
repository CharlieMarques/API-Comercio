namespace API_Comercio.Models.Domain
{
    public class ProductSale : Product
    {
        public int Amount { get; set; }
        public float ProfitPercentage {  get; set; }
    }
}
