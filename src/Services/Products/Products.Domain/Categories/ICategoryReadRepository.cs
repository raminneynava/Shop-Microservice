using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Products.Domain.Products;

namespace Products.Domain.Categories
{
    public interface ICategoryReadRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<Tuple<List<Product>, int>> GetByFilterPagedAsync(CategoryFilterPageReqDto request);
        Task<Product> GetAsync(int id);
        Task<Product> GetAsyncNoTracking(int id);
    }
}
