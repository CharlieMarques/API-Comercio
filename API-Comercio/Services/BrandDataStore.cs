using API_Comercio.Models.Domain;

namespace API_Comercio.Services
{
    public class BrandDataStore
    {
        public List<Brand>Brands { get; set; }
        public static BrandDataStore Current { get; } = new BrandDataStore();
        public BrandDataStore()
        {
            Brands = new List<Brand>()
            {
                new Brand()
                {
                    Id = 1,
                    Name = "Motorola",
                },
                new Brand()
                {
                    Id = 2,
                    Name = "Apple"
                },
                new Brand()
                {
                    Id = 3,
                    Name = "Samsung"
                },
                new Brand()
                {
                    Id = 4,
                    Name = "Xiaomi"
                },
                new Brand(){
                    Id = 5,
                    Name = "Ayudin"
                },
                new Brand(){
                    Id = 6,
                    Name = "Serenisima"
                }
            };
        }

    }
}
