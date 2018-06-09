using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ProdufraisServices.Contracts
{
    [DataContract]
    public class ProductContract
    {
        [DataMember]
        public int Id { get; }

        [DataMember]
        public string Code { get; }

        [DataMember]
        public string Label { get; }

        [DataMember]
        public string Description { get; }

        [DataMember]
        public float Price { get; }

        [DataMember]
        public long Stock { get; }

        [DataMember]
        public bool Active { get; } 

        [DataMember]
        public string Category { get; }

        [DataMember]
        public string Orders { get; }


        public ProductContract(Product data)
        {
            Id = data.Id;
            Code = data.Code;
            Label = data.Label;
            Description = data.Description;
            Price = data.Price;
            Stock = data.Stock;
            Active = data.Active;
            Category = JsonConvert.SerializeObject(data.Category);
            Orders = JsonConvert.SerializeObject(data.Orders);
        }
    }
}