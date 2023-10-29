using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "Esta sera la lista de productos";
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "Esta sera la lista de productos por id";
        }
    }
}