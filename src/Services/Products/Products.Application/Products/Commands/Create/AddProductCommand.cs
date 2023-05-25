using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;

using Products.Domain.Products;

namespace Products.Application.Products.Commands.Create
{
    public class AddProductCommand : ProductReqDto, IRequest<ProductResDto>
    {
    }
}
