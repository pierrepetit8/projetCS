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
        public int productId { get; set; }
        [Key]
        [ForeignKey("productId")]
        public Product product { get; set; }
        private string orderId { get; set; }
        [Key]
        [ForeignKey("orderId")]
        public Order order { get; set; }
        [Column("PO_QTY")]
        public long quantity { get; set; }
    }
}
