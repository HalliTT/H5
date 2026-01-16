using System;
using System.Collections.Generic;
using System.Text;
using MyNTier.BLL.Interface;
using MyNTier.DAL.Repositories;

namespace MyNTier.BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }
    }
}
