using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("T_STATUS")]
    public class Status
    {
        [Key]
        [Column("ST_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int statusId { get; set; }

        [Column("ST_LABEL")]
        public string label { get; set; }
    }
}
