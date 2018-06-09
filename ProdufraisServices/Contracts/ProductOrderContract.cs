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
        public int Id { get; set; }

        [DataMember]
        public long Quantity { get; set; }

        [DataMember]
        public string Product { get; set; }

        [DataMember]
        public string Order { get; set; }
        
        public ProductOrderContract(ProductOrder data) 
        {
            Id = data.Id;
            Quantity = data.Quantity;
            Product = JsonConvert.SerializeObject(data.Product);
            Order = JsonConvert.SerializeObject(data.Order);
        }
    }
}
