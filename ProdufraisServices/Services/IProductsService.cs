using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using ProdufraisServices.Contracts;

namespace ProdufraisServices.Services
{
    [ServiceContract]
    public interface IProductsService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
                   ResponseFormat = WebMessageFormat.Json,
                   RequestFormat = WebMessageFormat.Json,
                   UriTemplate = "products")]
        /// <summary>
        /// Gets all products.
        /// </summary>
        /// <returns>List of products.</returns>
        List<ProductContract> GetProducts();

        [OperationContract]
        [WebInvoke(Method = "GET",
                   ResponseFormat = WebMessageFormat.Json,
                   RequestFormat = WebMessageFormat.Json,
                   UriTemplate = "orders")]
        /// <summary>
        /// Gets all orders.
        /// </summary>
        /// <returns>List of orders.</returns>
        List<ProductOrderContract> GetOrders();

        [OperationContract]
        [WebInvoke(Method = "GET",
                   ResponseFormat = WebMessageFormat.Json,
                   RequestFormat = WebMessageFormat.Json,
                   UriTemplate = "stock?code={code}")]
        /// <summary>
        /// Gets the value of a product stock.
        /// </summary>
        /// <returns>The value of the stock.</returns>
        /// <param name="code">Code of the product.</param>
        long GetProductStock(string code);
    }
}
