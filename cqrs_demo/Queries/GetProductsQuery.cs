using cqrs_demo.Models;
using MediatR;

namespace cqrs_demo.Queries
{
    public class GetProductsQuery:IRequest<IEnumerable<Product>>
    {
       
    }

   
}
