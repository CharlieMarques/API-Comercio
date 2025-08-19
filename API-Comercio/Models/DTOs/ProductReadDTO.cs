namespace API_Comercio.Models.DTOs
{
    public class ProductReadDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ProductCode { get; set; } = string.Empty;
        public int CurrentStock { get; set; }
        public int MinimumStock { get; set; }
        public float Price { get; set; }
        public string Brand {  get; set; } = string.Empty;
        public List<string> Categories { get; set; } = new();
    }
}
