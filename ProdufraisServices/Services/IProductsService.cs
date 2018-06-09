using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ProdufraisServices.Contracts;

namespace ProdufraisServices
{
    [ServiceContract]
    public interface IProductsService
    {
        /// <summary>Get all products</summary>
        /// <returns>List of products</returns>
        [OperationContract]
        List<ProductContract> GetDataProducts();

        /// <summary>Get all orders</summary>
        /// <returns>List of orders</returns>
        [OperationContract]
        List<ProductOrderContract> GetDataOrders();

        /// <summary>Get a product stock</summary>
        /// <returns>Available amount of product</returns>
        /// <param name="code">Product's code</param>
        [OperationContract]
        int GetStockProduct(string code);

    }
}
