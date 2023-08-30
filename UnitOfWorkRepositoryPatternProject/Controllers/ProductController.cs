using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorkRepositoryPatternProject.Entities;
using UnitOfWorkRepositoryPatternProject.Interface;
using UnitOfWorkRepositoryPatternProject.Models;

namespace UnitOfWorkRepositoryPatternProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            try
            {
                var products = await _productService.GetAllProduct();
                return Ok(products);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("GetProduct")]
        public async Task<ActionResult<List<Product>>> GetProduct([FromQuery]PaginationDto pagination)
        {
            try
            {
                var products = await _productService.GetAllProductWithPagination(pagination);
                return Ok(products);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
