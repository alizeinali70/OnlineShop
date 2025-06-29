using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Domain.Entities.ProductEntity;

namespace OnlineShop.Application.Interfaces.ProductInterface
{
    public interface IProductRepository: IRepository<ProductUnit>
    {
        Task<IEnumerable<ProductUnit>> GetProductsByCategoryAsync(int categoryId);
        Task<IEnumerable<ProductUnit>> GetFeaturedProductsAsync(bool isFeatured);
        // Add other product-specific methods
    }
}
