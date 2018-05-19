using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("T_PRODUCT_ORDER")]
    public class ProductOrder
    {
        [Key]
        [ForeignKey("PR_ID")]
        public Product product { get; set; }
        [Key]
        [ForeignKey("OR_ID")]
        public Order order { get; set; }
        [Column("PO_QTY")]
        public long quantity { get; set; }
    }
}
