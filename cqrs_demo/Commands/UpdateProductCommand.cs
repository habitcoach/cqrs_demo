using cqrs_demo.Models;
using MediatR;

namespace cqrs_demo.Commands
{
    public class UpdateProductCommand:IRequest<Product>
    {
        public Product Product { get; set; }

        public UpdateProductCommand(Product product)
        {
            Product = product;
        }
    }
}
