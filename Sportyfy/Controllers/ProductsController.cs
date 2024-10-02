using Microsoft.AspNetCore.Mvc;
using Sportyfy.Entities;

namespace Sportyfy.Controllers
{

    //[controller] eshte i njejt me emrin e fajllit ProductsController
    [Route("api/v1/[controller]")]
    [ApiController]

    public class ProductsController : ControllerBase
    {

    
        //in memory list of products(simulu data store(db))
        private static List<Product>_products = new List<Product>

        {
  new Product
            {
                Id = 1,
                Name = "Tenniss Racket",
                Description = "A high-quality tennis racket",
                Price = 150.99m,
                PictureUrl = "http://example.com/tennis-racket.png",
                ProductTypeId = 1,
                ProductBrandId = 1,
                //ctrl click shkon te  id dhe name
                ProductType = new ProductType 
                { 
                    Id = 1,
                    Name = "Sports Equipment"
                },
                ProductBrand = new ProductBrand 
                { 
                    Id = 1,
                    Name = "Wilson" 
                }
            },
            new Product
            {
                Id = 2,
                Name = "Running Shoes",
                Description = "Comfortable running shoes",
                Price = 85.50m,
                PictureUrl = "http://example.com/running-shoes.png",
                ProductTypeId = 2,
                ProductBrandId = 2,
                ProductType = new ProductType 
                { 
                    Id = 2, 
                    Name = "Footwear" 
                },
                ProductBrand = new ProductBrand 
                { 
                    Id = 2,
                    Name = "Nike"
                }
            },
            new Product
            {
                Id = 3,
                Name = "Pro Tennis Racket",
                Description = "A premium tennis racket used by professionals.",
                Price = 250.00m,
                PictureUrl = "http://example.com/pro-tennis-racket.png",
                ProductTypeId = 1,
                ProductBrandId = 1,
                ProductType = new ProductType 
                { 
                    Id = 1,
                    Name = "Sports Equipment"
                },
                ProductBrand = new ProductBrand
                { 
                    Id = 1, 
                    Name = "Wilson" 
                }
            },
            new Product
            {
                Id = 4,
                Name = "Speedster Running Shoes",
                Description = "Lightweight running shoes designed for speed.",
                Price = 120.75m,
                PictureUrl = "http://example.com/speedster-running-shoes.png",
                ProductTypeId = 2,
                ProductBrandId = 2,
                ProductType = new ProductType 
                { Id = 2, 
                    Name = "Footwear" 
                },
                ProductBrand = new ProductBrand 
                {   
                    Id = 2,
                    Name = "Nike" 
                }
            },
            new Product
            {
                Id = 5,
                Name = "Tennis Jersey",
                Description = "Comfortable tennis jersey for optimal performance.",
                Price = 45.00m,
                PictureUrl = "http://example.com/tennis-jersey.png",
                ProductTypeId = 3,
                ProductBrandId = 3,
                ProductType = new ProductType 
                { 
                    Id = 3, 
                    Name = "Apparel"
                },
                ProductBrand = new ProductBrand 
                { Id = 3,
                    Name = "Adidas" 
                }
            },
            new Product
            {
                Id = 6,
                Name = "Sports Jersey",
                Description = "Breathable sports jersey, perfect for any sport.",
                Price = 50.00m,
                PictureUrl = "http://example.com/sports-jersey.png",
                ProductTypeId = 3,
                ProductBrandId = 4,
                ProductType = new ProductType { Id = 3, Name = "Apparel" },
                ProductBrand = new ProductBrand { Id = 4, Name = "Puma" }
            }

        };

        //GET; api/v1/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAllProducts()
        {
            return Ok(_products);
        }

    }
}
