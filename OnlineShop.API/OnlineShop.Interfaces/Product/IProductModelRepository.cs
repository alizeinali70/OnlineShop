using Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IProductModelRepository:IRepository<ProductType>
    {
        Task<IEnumerable<ProductType>> GetModelsByProductIdAsync(int productId);
        Task<IEnumerable<ProductType>> GetModelsByCategoryIdAsync(int categoryId);
        Task<IEnumerable<ProductType>> GetFeaturedModelsAsync(bool isFeatured);
        // Add other model-specific methods if needed
    }
}
