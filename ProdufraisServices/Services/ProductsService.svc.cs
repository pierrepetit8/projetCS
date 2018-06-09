using System;
using System.Collections.Generic;
using Model;
using ProdufraisServices.Contracts;

namespace ProdufraisServices
{
    public class ProductsService : IProductsService
    {
        private BusinessManager Manager;

        public List<ProductOrderContract> GetDataOrders()
        {
            Manager = BusinessManager.Instance;
            List<ProductOrderContract> data = new List<ProductOrderContract>();
            Manager.getAllProductOrders().ForEach(
                po => data.Add(new ProductOrderContract(po))
            );
            return data;
        }

        public List<ProductContract> GetDataProducts()
        {
            Manager = BusinessManager.Instance;
            List<ProductContract> data = new List<ProductContract>();
            Manager.GetAllProducts().ForEach(
                p => data.Add(new ProductContract(p))
            );
            return data;
        }

        public long GetStockProduct(string code)
        {
            Manager = BusinessManager.Instance;
            Product data = Manager.getProductByCode(code);
            if (data != null)
            {
                return data.Stock;
            }
            return 0;
        }
    }
}
