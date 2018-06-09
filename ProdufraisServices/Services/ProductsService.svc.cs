using System;
using System.Collections.Generic;
using Model;
using ProdufraisServices.Contracts;

namespace ProdufraisServices
{
    public class ProductsService : IProductsService
    {
        public List<ProductOrderContract> GetDataOrders()
        {
            throw new NotImplementedException();
        }

        public List<ProductContract> GetDataProducts()
        {
            throw new NotImplementedException();
        }

        int IProductsService.GetStockProduct(string code)
        {
            throw new NotImplementedException();
        }
    }
}
