using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("T_ORDER")]
    public class Order
    {
        [Key]
        [Column("OR_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("OR_DATE")]
        public DateTime Date { get; set; }

        [Column("OR_OBSERVATION")]
        public string Observation { get; set; }

        [ForeignKey("StatusId")]
        public Status Status { get; set; }

        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        public int StatusId { get; set; }

        public int ClientId { get; set; }

        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
