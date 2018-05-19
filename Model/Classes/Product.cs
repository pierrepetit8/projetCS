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
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int productId { get; set; }
        [Column("PR_LABEL")]
        public string label { get; set; }
        [Column("PR_PRICE")]
        public float price { get; set; }
        [Column("PR_CODE")]
        public string code { get; set; }
        [Column("PR_ACTIVE")]
        public bool active { get; set; }
        [Column("PR_STOCK")]
        public long stock { get; set; }
        public string categoryId { get; set; }
        [ForeignKey("categoryId")]
        public Category category { get; set; }
        [Column("PR_DESCRIPTION")]
        public string description { get; set; }

        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
