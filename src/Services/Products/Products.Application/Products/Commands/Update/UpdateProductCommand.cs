using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;
using Products.Domain.Products;

namespace Products.Application.Products.Commands.Update
{
    public class UpdateProductCommand : ProductReqDto, IRequest<bool>
    {

    }
}
