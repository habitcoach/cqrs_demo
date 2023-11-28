using cqrs_demo.Models;
using MediatR;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace cqrs_demo.Queries
{
    public class GetProductsByIdQuery:IRequest<Product>
    {
      

        public int ProductId { get; set; }

        public GetProductsByIdQuery(int productId)
        {
            ProductId = productId;
        }
    }

}
