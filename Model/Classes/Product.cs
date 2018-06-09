using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("T_PRODUCT")]
    public class Product
    {
        [Key]
        [Column("PR_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("PR_LABEL")]
        public string Label { get; set; }

        [Column("PR_PRICE")]
        public float Price { get; set; }

        [Column("PR_CODE")]
        public string Code { get; set; }

        [Column("PR_ACTIVE")]
        public bool Active { get; set; }

        [Column("PR_STOCK")]
        public long Stock { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [Column("PR_DESCRIPTION")]
        public string Description { get; set; }

        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
