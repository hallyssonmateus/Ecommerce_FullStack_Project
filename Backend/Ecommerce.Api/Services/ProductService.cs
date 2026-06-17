using Ecommerce.Api.Domain.Entities;
using Ecommerce.Api.Domain.Interfaces;
using Ecommerce.Api.Services.Interfaces;

namespace Ecommerce.Api.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        // Injeção de Dependência: O serviço depende da INTERFACE do repositório, não da classe concreta!
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<bool> CreateProductAsync(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name))
                throw new ArgumentException("O nome do produto é obrigatório.");

            if (product.Price <= 0)
                throw new ArgumentException("O preço do produto deve ser maior que zero.");

            if (product.StockQuantity < 0)
                throw new ArgumentException("A quantidade em estoque não pode ser negativa.");

            await _productRepository.AddAsync(product);
            return await _productRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetCatalogProductsAsync()
        {
            return await _productRepository.GetActiveProductsAsync();
        }

        public async Task<Product?> GetProductDetailsAsync(int id)
        {
            if (id <= 0) return null;

            return await _productRepository.GetByIdAsync(id);
        }
    }
}
