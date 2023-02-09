using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ORGInvent.Data.Tables
{
    [Table("MB")]
    public class MB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public string ChipsetName { get; set; }
    }
}
