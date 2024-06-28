using ScarpeDue.Models;

namespace ScarpeDue.Data
{
    public class ProductR
    {
        private static List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Scarpe della lidl",
                Price = 1500.99m,
                Description = "Finalmente sono tornate le scarpe della lidl!",
                CoverImageUrl = "/images/cover.jpg",
                AdditionalImage1Url = "/images/img1.jpg",
                AdditionalImage2Url = "/images/img2.jpg"
            },

            new Product
            {
                 Id = 2,
                Name = "Scarpe di Dragon Ball",
                Price = 9000.99m,
                Description = "Acquista subito queste scarpe in onore di toriyama",
                CoverImageUrl = "/images/cover2.jpg",
                AdditionalImage1Url = "/images/add1.jpg",
                AdditionalImage2Url = "/images/add2.jpg"
            },
              new Product
            {
                 Id = 3,
                Name = "Scarpe di Naruto ESCLUSIVA",
                Price = 200000000.99m,
                Description = "IO CREDO IN ME",
                CoverImageUrl = "/images/covern.jpg",
                AdditionalImage1Url = "/images/n1.jpg",
                AdditionalImage2Url = "/images/n2.jpg"
            },
                new Product
            {
                 Id = 4,
                Name = "Pippo l'informatico",
                Price = 0.01m,
                Description = "???",
                CoverImageUrl = "/images/pippoCover.png",
                AdditionalImage1Url = "/images/pippo.jpg",
                AdditionalImage2Url = "/images/superman.png"
            }
        };

        public static List<Product> GetAllProducts()
        {
            return products;
        }

        public static Product GetProductById(int id)
        {
            return products.Find(p => p.Id == id);
        }
    }
}

