using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("T_CLIENT")]
    public class Client
    {
        [Key]
        [Column("CLI_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id{ get; set; }

        [Column("CLI_LASTNAME")]
        public string LastName { get; set; }

        [Column("CLI_FIRSTNAME")]
        public string FirstName { get; set; }

        [Column("CLI_ACTIVE")]
        public bool Active { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
