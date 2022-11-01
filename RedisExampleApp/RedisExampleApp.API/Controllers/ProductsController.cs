using Microsoft.AspNetCore.Mvc;
using RedisExampleApp.API.Models;
using RedisExampleApp.API.Repositories;
using RedisExampleApp.Cache;

namespace RedisExampleApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepo;

        public ProductsController(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            return Ok(await _productRepo.GetAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            return Ok(await _productRepo.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {

            return Created(string.Empty, await _productRepo.CreateAsync(product));
        }
    }
}
