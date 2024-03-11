using Ecommerce.Server.Repositories.Interfaces;
using Ecommerce.Shared.DTO;
using Ecommerce.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo productRepo;
        public ProductController(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceModel>> AddProduct(Product NewProduct)
        {
            return Ok(await productRepo.AddProduct(NewProduct));
        }

        [HttpGet("Get-Products")]
        public async Task<ActionResult<ServiceModel>> GetProducts()
        {
            return Ok(await productRepo.GetProducts());
        }

        [HttpGet("Get-Product/{ProductId:int}")]
        public async Task<ActionResult<ServiceModel>> GetProduct(int ProductId)
        {
            return Ok(await productRepo.GetProduct(ProductId));
        }
    }
}
