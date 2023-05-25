using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Products.Domain.Products;

namespace Products.Domain.Categories
{
    public interface ICategoryWriteRepository
    {
        Task<Category> AddAsync(Category product);
        Task<Category> UpdateAsync(Category product);
        Task DeleteAsync(Category product);
    }
}
