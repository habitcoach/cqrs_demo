using cqrs_demo.Models;
using MediatR;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace cqrs_demo.Commands
{
    public class AddProductCommand:IRequest
    {
        public Product Product { get; set; }
      

        public AddProductCommand(Product product)
        {
            Product = product;

        }
    }
}
