using Model;
using System;
using System.Runtime.Serialization;

namespace ProdufraisServices.Contracts
{
    [DataContract]

    public class ProductOrderContract
    {
        
        public ProductOrderContract(ProductOrder data) 
        {
            Data = data;
        }

        [DataMember]
        public ProductOrder Data { get; }
    }
}
