using Model;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace ProdufraisServices.Contracts
{
    [DataContract]
    public class ProductOrderContract
    {
        [DataMember]
        public int Id { get; }

        [DataMember]
        public long Quantity { get; }

        [DataMember]
        public string Product { get; }

        [DataMember]
        public string Order { get; }
        
        public ProductOrderContract(ProductOrder data) 
        {
            Id = data.Id;
            Quantity = data.Quantity;
            Product = JsonConvert.SerializeObject(data.Product);
            Order = JsonConvert.SerializeObject(data.Order);
        }
    }
}
