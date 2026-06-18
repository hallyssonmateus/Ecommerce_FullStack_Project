using Ecommerce.Api.Domain.Entities;
using Ecommerce.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        // Listar todos os produtos no catálogo
        [HttpGet]
        public async Task<IActionResult> GetCatalog()
        {
            var products = await _productService.GetCatalogProductsAsync();
            return Ok(products);
        }
        // Obter detalhes de um produto específico
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetDetails(int id)
        {
            var product = await _productService.GetProductDetailsAsync(id);
            if (product == null)
                return NotFound(new { message = $"Produto com ID {id} não encontrado." });

            return Ok(product);
        }

        // Cadastrar um novo produto (Admin)
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Product product)
        {
            try
            {
                var success = await _productService.CreateProductAsync(product);
                if (!success)
                    return BadRequest(new { message = "Não foi possível salvar o produto." });

                return CreatedAtAction(nameof(GetDetails), new { id = product.Id }, product);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
