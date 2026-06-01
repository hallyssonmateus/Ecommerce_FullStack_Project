using Ecommerce.Api.Domain.Entities;
using Ecommerce.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Api.Application.Services
{
    public class ProductService
    {
        private readonly AppDbContext _context;
        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.Include(p => p.Category).ToListAsync();
        }
    }
}