using cqrs_demo.Commands;
using cqrs_demo.Repository;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace cqrs_demo.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand>
    {
        private readonly IProductRepo _context;

        public AddProductHandler(IProductRepo context)
        {
            _context = context;
        }
        Task IRequestHandler<AddProductCommand>.Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            _context.AddProduct(request.Product);

            return Task.CompletedTask;
        }
    }
}
