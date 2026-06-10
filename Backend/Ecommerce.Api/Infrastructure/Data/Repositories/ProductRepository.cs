using Ecommerce.Api.Domain.Entities;
using Ecommerce.Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Api.Infrastructure.Data.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly AppDbContext _context;

        // Construtor para injeção de dependência do DbContext
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _context.Products
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        async Task<IEnumerable<Product>> IProductRepository.GetActiveProductsAsync()
        {
            return await _context.Products
                .Where(p => p.IsActive)
                .ToListAsync();
        }

        async Task<IEnumerable<Product>> IProductRepository.GetByCategoryIdAsync(int categoryId)
        {
            return await _context.Products
                .Where(p => p.CategoryId == categoryId && p.IsActive)
                .ToListAsync();
        }

        async Task IProductRepository.AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
        }

        async Task<bool> IProductRepository.SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
