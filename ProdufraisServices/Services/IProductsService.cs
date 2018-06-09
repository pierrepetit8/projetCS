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
        List<ProductContract> GetProducts();

        [OperationContract]
        [WebInvoke(Method = "GET",
                   ResponseFormat = WebMessageFormat.Json,
                   RequestFormat = WebMessageFormat.Json,
                   UriTemplate = "orders")]
        List<ProductOrderContract> GetOrders();

        [OperationContract]
        [WebInvoke(Method = "GET",
                   ResponseFormat = WebMessageFormat.Json,
                   RequestFormat = WebMessageFormat.Json,
                   UriTemplate = "stock?code={code}")]
        long GetProductStock(string code);
    }
}
