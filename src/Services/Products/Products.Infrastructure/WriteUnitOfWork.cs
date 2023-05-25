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
    public class WriteUnitOfWork : IWriteUnitOfWork
    {
        private readonly ProductDbContext _context;

        public WriteUnitOfWork(ProductDbContext context)
        {
            _context = context;
        }
        private ProductWriteRepository _productWriteRepository;

        public IProductWriteRepository ProductWriteRepository
        {
            get
            {
                return _productWriteRepository ??= new ProductWriteRepository(_context);
            }
        }
    }
}
