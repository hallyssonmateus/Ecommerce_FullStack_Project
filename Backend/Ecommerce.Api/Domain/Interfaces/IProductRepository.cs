using Ecommerce.Api.Domain.Entities;

namespace Ecommerce.Api.Domain.Interfaces
{
    public interface IProductRepository
    {
        // Retorna todos os produtos ativos
        Task<IEnumerable<Product>> GetActiveProductsAsync();
        // Busca um produto por ID
        Task<Product?> GetByIdAsync(int id);
        // Busca produtos filtrados por categoria
        Task<IEnumerable<Product>> GetByCategoryIdAsync(int categoryId);
        // Método para o admin usar para cadastrar uma nova bijuteria
        Task AddAsync(Product product);
        // Salva as alterações no banco de dados
        Task<bool> SaveChangesAsync();
    }
}
