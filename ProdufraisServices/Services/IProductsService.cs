using System.Collections.Generic;
using System.ServiceModel;
using ProdufraisServices.Contracts;

namespace ProdufraisServices
{
    [ServiceContract]

    public interface IProductsService
    {
        [OperationContract]
        /// <summary>Get all products</summary>
        /// <returns>List of products</returns>
        List<ProductContract> GetDataProducts();

        [OperationContract]
        /// <summary>Get all orders</summary>
        /// <returns>List of orders</returns>
        List<ProductOrderContract> GetDataOrders();

        [OperationContract]
        /// <summary>Get a product stock</summary>
        /// <returns>Available amount of product</returns>
        /// <param name="code">Product's code</param>
        long GetStockProduct(string code);

    }
}
