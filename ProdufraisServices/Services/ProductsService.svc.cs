using System;
using System.Collections.Generic;
using Model;
using ProdufraisServices.Contracts;

namespace ProdufraisServices.Services
{
    public class ProductsService : IProductsService
    {
        private BusinessManager _manager;

        public List<ProductContract> GetProducts()
        {
            _manager = BusinessManager.Instance;
            List<ProductContract> data = new List<ProductContract>();
            _manager.GetAllProducts().ForEach(
                p => data.Add(new ProductContract(p))
            );
            return data;
        }

        public List<ProductOrderContract> GetOrders()
        {
            _manager = BusinessManager.Instance;
            List<ProductOrderContract> data = new List<ProductOrderContract>();
            _manager.GetAllProductOrders().ForEach(
                po => data.Add(new ProductOrderContract(po))
            );
            return data;
        }

        public long GetProductStock(string code)
        {
            _manager = BusinessManager.Instance;
            try
            {
                Product data = _manager.GetProductByCode(code);
                return data.Stock;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
