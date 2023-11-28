using cqrs_demo.Data;
using cqrs_demo.Models;
using cqrs_demo.Queries;
using cqrs_demo.Repository;
using MediatR;
using System.Runtime.InteropServices;

namespace cqrs_demo.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly IProductRepo _context;

        public GetProductsHandler(IProductRepo context)
        {
                _context = context;
        }
        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return await _context.GetProduct();
        }
    }

}
