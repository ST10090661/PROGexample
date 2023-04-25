using APIDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace APIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet ]
        [Route("Product")]
        public string GetProduct()
        {
            return "Milk";
        }

        [HttpGet]
        [Route("All")]
        public IEnumerable<Product> GetProducts() {
            return new List<Product>
            {
                new Product(1,"Coke"),
                new Product(1,"Butter"),
                new Product(1,"milk"),
                new Product(1,"sweets"),
            };
}
    }
}
