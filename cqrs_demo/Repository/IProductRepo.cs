using cqrs_demo.Models;

namespace cqrs_demo.Repository
{
    public interface IProductRepo
    {
        public void AddProduct(Product product);
        public Task< List<Product>> GetProduct();

        public Task<Product> UpdateProduct(Product productId);
        public Task<Product> GetProductById(int productId);
    }
}
