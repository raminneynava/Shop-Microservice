using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;
using Products.Domain.Products;
using Products.Domain;

namespace Products.Application.Products.Queries.GetProducts
{
    public class GetProductQuery : IRequest<ProductResDto>
    {
        public int Id { get; set; }

    }
}
