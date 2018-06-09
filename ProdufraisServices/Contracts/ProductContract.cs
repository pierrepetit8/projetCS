using Model;
using System;
using System.Runtime.Serialization;

namespace ProdufraisServices.Contracts
{
    [DataContract]
    public class ProductContract
    {

        public ProductContract(Product data)
        {
            Data = data;
        }

        [DataMember]
        public Product Data { get; }
    }
}