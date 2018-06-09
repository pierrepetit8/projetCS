using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Model;

namespace ProdufraisServices
{
    public class ProductsService : IProductsService
    {

        List<ProductOrder> IProductsService.GetDataOrders()
        {
            throw new NotImplementedException();
        }

        List<Product> IProductsService.GetDataProducts()
        {
            throw new NotImplementedException();
        }

        int IProductsService.GetStockProduct(string code)
        {
            throw new NotImplementedException();
        }
    }
}
