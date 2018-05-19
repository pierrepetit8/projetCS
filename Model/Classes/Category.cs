using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("T_CATEGORY")]
    public class Category
    {
        [Key]
        [Column("CAT_ID")]
        public string categoryId { get; set; }
        [Column("CAT_LABEL")]
        public string label { get; set; }
        [Column("CAT_ACTIVE")]
        public bool active { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
