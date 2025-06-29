using OnlineShop.Domain.Entities.ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Interfaces.ProductInterface
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        Task<IEnumerable<ProductCategory>> GetActiveCategoriesAsync();
    }
}
