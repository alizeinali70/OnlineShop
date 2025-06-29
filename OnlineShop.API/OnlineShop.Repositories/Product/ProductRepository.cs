using Entities.Product;
using Interfaces;
using Microsoft.EntityFrameworkCore;

using OnlineShop.Infrastructure.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Repositories.Product
{
    public class ProductRepository : Repository<ProductUnit>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ProductUnit>> GetProductsByCategoryAsync(int categoryId)
        {
            return await _context.Products
                .Where(p => p.CategoryId == categoryId && p.Is_Active)
                .ToListAsync();
        }

        public async Task<IEnumerable<ProductUnit>> GetFeaturedProductsAsync(bool isFeatured)
        {
            return await _context.Products
                .Where(p => p.Special_Offer == isFeatured && p.Is_Active)
                .ToListAsync();
        }
    }
}
