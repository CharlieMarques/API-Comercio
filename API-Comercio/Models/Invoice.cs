namespace API_Comercio.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public Client Client { get; set; } = new Client();
        public Sale Sale { get; set; } = new Sale();
        public float SumTotal {  get; set; }
    }
}
