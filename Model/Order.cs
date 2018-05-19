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
        private string orderId { get; set; }
        [Column("OR_DATE")]
        private DateTime dateOrder { get; set; }
        [Column("OR_OBSERVATION")]
        private string observation { get; set; }
        [Column("OR_STATUS")]
        private int statusId { get; set; }
        [ForeignKey("CLI_ID")]
        private Client client { get; set; }
    }
}
