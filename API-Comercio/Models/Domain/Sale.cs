namespace API_Comercio.Models.Domain
{
    public class Sale
    {
        public int Id { get; set; }
        public List<ProductSale> ProductsSale {  get; set; } = new List<ProductSale>();
        public Client Client { get; set; } = new Client();
        public DateTime? Date { get; set; }
    }
}
