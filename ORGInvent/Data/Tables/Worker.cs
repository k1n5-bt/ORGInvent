using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ORGInvent.Data.Tables
{
    [Table("Workers")]
    public class Worker
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public int Floor { get; set; }

        public string Cabinet { get; set; }

        public string Department { get; set; }

        public string Function { get; set; }

        public string Phone { get; set; }
    }
}
