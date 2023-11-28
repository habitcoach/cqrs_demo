using cqrs_demo.Models;
using cqrs_demo.Queries;
using cqrs_demo.Repository;
using MediatR;

namespace cqrs_demo.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductsByIdQuery, Product>
    {

        private readonly IProductRepo _context;

        public GetProductByIdHandler(IProductRepo context)
        {
            _context = context;
        }
        public async Task<Product> Handle(GetProductsByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.GetProductById(request.ProductId);
        }
    }
}
