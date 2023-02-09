using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ORGInvent.Data.Tables
{
    [Table("GeneralInformation")]
    public class GeneralInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Model { get; set; }

        [Required]
        public string InventoryNumber { get; set; }

        public string Manufacturer { get; set; }

        public string IpAddress { get; set; }
    }
}
