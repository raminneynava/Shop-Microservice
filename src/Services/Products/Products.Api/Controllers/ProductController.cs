using System.Collections.Generic;

using AutoMapper;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using Products.Application.Products.Commands.Create;
using Products.Application.Products.Commands.Delete;
using Products.Application.Products.Commands.Update;
using Products.Application.Products.Queries.GetProducts;
using Products.Application.Products.Queries.GetProductsList;
using Products.Domain;
using Products.Domain.Products;

namespace Products.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediatr;

        public ProductController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }
        [HttpGet("{id}")]
        public async Task<ProductResDto> Get(int id)
        {
            return await _mediatr.Send(new GetProductQuery { Id = id });
        }

        [HttpGet]
        public async Task<PaginitionResDto<List<ProductResDto>>> Get()
        {
            return await _mediatr.Send(new GetProductsListQuery { PageSize = 10, PageIndex = 0 });
        }
        [HttpPost]
        public async Task<ProductResDto> Post(AddProductCommand request)
        {
         return await _mediatr.Send(request);
        }

        [HttpPut]
        public async Task<bool> Put(UpdateProductCommand request)
        {
            return await _mediatr.Send(request);
        }

        [HttpDelete]
        public async Task<bool> Delete(DeleteProductCommand request)
        {
            return await _mediatr.Send(request);
        }
    }
}
