using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("T_CATEGORY")]
    public class Category
    {
        [Key]
        [Column("CAT_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("CAT_LABEL")]
        public string Label { get; set; }

        [Column("CAT_ACTIVE")]
        public bool Active { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
