using cqrs_demo.Commands;
using cqrs_demo.Models;
using cqrs_demo.Queries;
using cqrs_demo.Repository;
using MediatR;

namespace cqrs_demo.Handlers
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, Product>
    {

        private readonly IProductRepo _context;

        public UpdateProductHandler(IProductRepo context)
        {
            _context = context;
        }
      
        async Task<Product> IRequestHandler<UpdateProductCommand, Product>.Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
             await _context.UpdateProduct(request.Product);
            return request.Product;
        }
    }
}

