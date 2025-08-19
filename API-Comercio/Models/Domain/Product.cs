namespace API_Comercio.Models.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ProductCode { get; set; } = string.Empty;
        public int CurrentStock { get; set; }
        public int MinimumStock { get; set; }
        public float Price { get; set; }
        public Brand Brand { get; set; } = new Brand();
        public List<Category> ListCategory { get; set; } = new List<Category>();
        public List<Supplier> ListSupplier { get; set; } = new List<Supplier>();
        public int BrandId {  get; set; }
        public int CategoryId {  get; set; }

    }
}
