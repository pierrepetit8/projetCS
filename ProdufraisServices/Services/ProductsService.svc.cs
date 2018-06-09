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
            throw new NotImplementedException();
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

        long IProductsService.GetStockProduct(string code)
        {
            Manager = BusinessManager.Instance;
            Product data = Manager.getProductByCode(code);
            return data == null ? 0 : data.stock;
        }
    }
}
