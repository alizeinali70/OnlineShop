using Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IProductModelRepository:IRepository<ProductModel>
    {
        Task<IEnumerable<ProductModel>> GetModelsByProductIdAsync(int productId);
        Task<IEnumerable<ProductModel>> GetModelsByCategoryIdAsync(int categoryId);
        Task<IEnumerable<ProductModel>> GetFeaturedModelsAsync(bool isFeatured);
        // Add other model-specific methods if needed
    }
}
