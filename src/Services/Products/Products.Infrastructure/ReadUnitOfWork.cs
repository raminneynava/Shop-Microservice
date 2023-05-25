using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Products.Domain.Products;
using Products.Domain;
using Products.Infrastructure.Context;
using Products.Infrastructure.Products;

namespace Products.Infrastructure
{
    public class ReadUnitOfWork : IReadUnitOfWork
    {
        private readonly ProductDbContext _context;

        public ReadUnitOfWork(ProductDbContext context)
        {
            _context = context;
        }
        private ProductReadRepository _productReadRepository;

        public IProductReadRepository ProductReadRepository
        {
            get
            {
                return _productReadRepository ??= new ProductReadRepository(_context);
            }
        }
    }
}
