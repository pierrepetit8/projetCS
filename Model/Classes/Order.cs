using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("T_ORDER")]
    public class Order
    {
        [Key]
        [Column("OR_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderId { get; set; }

        [Column("OR_DATE")]
        public DateTime dateOrder { get; set; }

        [Column("OR_OBSERVATION")]
        public string observation { get; set; }

        [Column("OR_STATUS")]
        public int statusId { get; set; }

        public int clientId { get; set; }

        [ForeignKey("clientId")]
        public Client client { get; set; }

        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
