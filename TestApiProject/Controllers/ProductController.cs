using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Threading.Tasks;
using TestApiProject.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _product;

        public ProductController(IProductService product)
        { 
        _product = product;
        }
        
        //GET api/<ProductController>/5
        [Route("ShowProductList")]
        [HttpGet]
        public async Task<IEnumerable<ProductDetails>> showProductList()
        {
           // ProductDetails pcm = new ProductDetails();
            var details = await _product.GetProductDetails();
            return details;

        }
       
    }
}
