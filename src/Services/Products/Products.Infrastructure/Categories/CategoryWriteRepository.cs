using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Products.Domain.Categories;
using Products.Domain.Products;

namespace Products.Infrastructure.Categories
{
    internal class CategoryWriteRepository : ICategoryWriteRepository
    {
        public Task<Category> AddAsync(Category product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Category product)
        {
            throw new NotImplementedException();
        }

        public Task<Category> UpdateAsync(Category product)
        {
            throw new NotImplementedException();
        }
    }
}
