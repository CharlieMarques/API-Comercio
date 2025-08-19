namespace API_Comercio.Models.DTOs
{
    public class ProductCreateUpdateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ProductCode { get; set; } = string.Empty;
        public int CurrentStock { get; set; }
        public int MinimumStock { get; set; }
        public float Price { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
    }
}
