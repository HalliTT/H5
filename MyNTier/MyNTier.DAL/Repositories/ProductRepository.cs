using System;
using System.Collections.Generic;
using System.Text;
using MyNTier.DAL.Interface;
using MyNTier.DataAccess;

namespace MyNTier.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
