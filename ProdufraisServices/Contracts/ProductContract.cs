using Model;
using System.Runtime.Serialization;

namespace ProdufraisServices.Contracts
{
    [DataContract]
    public class ProductContract
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int CategoryId { get; set; }

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

        public ProductContract(Product data)
        {
            Id = data.Id;
            CategoryId = data.CategoryId;
            Code = data.Code;
            Label = data.Label;
            Description = data.Description;
            Price = data.Price;
            Stock = data.Stock;
            Active = data.Active;
        }
    }
}