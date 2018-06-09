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
        public int Id { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Label { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public float Price { get; set; }

        [DataMember]
        public long Stock { get; set; }

        [DataMember]
        public bool Active { get; set; } 

        [DataMember]
        public string Category { get; set; }

        [DataMember]
        public string Orders { get; set; }


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