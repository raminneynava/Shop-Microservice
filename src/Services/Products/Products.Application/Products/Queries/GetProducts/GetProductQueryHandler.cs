using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;
using Products.Application.Products.Queries.GetProductsList;
using Products.Domain.Products;
using Products.Domain;
using AutoMapper;
using Products.Application.Exception;

namespace Products.Application.Products.Queries.GetProducts
{
    internal class GetProductsListQueryHandler : IRequestHandler<GetProductQuery, ProductResDto>
    {
        private readonly IReadUnitOfWork _readUnitOfWork;
        private readonly IMapper _mapper;

        public GetProductsListQueryHandler(IMapper mapper, IReadUnitOfWork readUnitOfWork)
        {
            _mapper = mapper;
            _readUnitOfWork = readUnitOfWork;
        }

        public async Task<ProductResDto> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var product = await _readUnitOfWork.ProductReadRepository.GetAsyncNoTracking(request.Id);
            if (product == null)
            {
                throw new NotFoundException("Product", request.Id);
            }
           return _mapper.Map<ProductResDto>(product);
        }
    }
}
