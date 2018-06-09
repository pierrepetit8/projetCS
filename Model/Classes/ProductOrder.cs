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
        [Column("PO_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productOrderId { get; set; }
        public int productId { get; set; }
        [ForeignKey("productId")]
        public Product product { get; set; }
        public int orderId { get; set; }
        [ForeignKey("orderId")]
        public Order order { get; set; }
        [Column("PO_QTY")]
        public long quantity { get; set; }
    }
}
