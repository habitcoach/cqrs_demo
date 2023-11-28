using cqrs_demo.Data;
using cqrs_demo.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace cqrs_demo.Repository
{
    public class ProductRepo : IProductRepo
    {
        private readonly ApplicationDbContext _context;

        public ProductRepo(ApplicationDbContext context)
        {
                _context = context;
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public async Task <List<Product>> GetProduct()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductById(int productId)
        {
            var Existingproduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == productId);
            if (Existingproduct != null)
            {
                return Existingproduct;
            }
             throw new Exception("Product not found");
        }

        public  async Task<Product> UpdateProduct(Product product)
        {
          
            
            if (product != null)
            {

                _context.Update(product);
                await _context.SaveChangesAsync();

            }
            return product;
        }
    }
}
