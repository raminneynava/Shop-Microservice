using Products.Application.Products.Commands.Create;
using Products.Domain.Products;
using Products.Infrastructure.Context;
using System.Reflection;

namespace Products.Api.Configuration
{
    public class Assemblies
    {
        public static readonly Assembly EntityAssembly = typeof(Product).Assembly;
        public static readonly Assembly ApplicationAssembly = typeof(AddProductCommand).Assembly;
        public static readonly Assembly InfrastructureAssembly = typeof(ProductDbContext).Assembly;
    }
}
