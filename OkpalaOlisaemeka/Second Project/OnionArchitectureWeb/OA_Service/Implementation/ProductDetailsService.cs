using OA_DataAccess;
using OA_Repository;
using OA_Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA_Service.Implementation
{
    public class ProductDetailsService : IProductDetailsService
    {
        private readonly IRepository<ProductDetails> _repository;

        public ProductDetailsService(IRepository<ProductDetails> repository)
        {
            _repository = repository;
        }

        public ProductDetails GetProductDetail(int id)
        {
            return _repository.Get(id);
        }
    }
}
