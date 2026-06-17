using Ecommerce.Api.Domain.Entities;

namespace Ecommerce.Api.Services.Interfaces
{
    public interface IProductService
    {
        // Retorna todos os produtos ativos
        Task<IEnumerable<Product>> GetCatalogProductsAsync();
        // Retorna os detalhes de um produto especifico
        Task<Product?> GetProductDetailsAsync(int id);
        // Regra de negócio para o admin cadastrar um novo produto com validações
        Task<bool> CreateProductAsync(Product product);
    }
}
