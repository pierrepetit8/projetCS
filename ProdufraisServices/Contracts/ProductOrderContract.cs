using Model;
using System.Runtime.Serialization;

namespace ProdufraisServices.Contracts
{
    [DataContract]
    public class ProductOrderContract
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        public int OrderId { get; set; }

        [DataMember]
        public long Quantity { get; set; }
        
        public ProductOrderContract(ProductOrder data) 
        {
            Id = data.Id;
            Quantity = data.Quantity;
            ProductId = data.ProductId;
            OrderId = data.OrderId;
        }
    }
}
