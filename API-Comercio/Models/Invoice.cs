namespace API_Comercio.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        public Sale Sale { get; set; } = new Sale();
        public float SumTotal {  get; set; }
    }
}
