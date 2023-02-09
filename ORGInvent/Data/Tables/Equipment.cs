using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ORGInvent.Data.Tables
{
    [Table("Equipments")]
    public class Equipment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public TypeOfEquipments Type { get; set; }

        public long GeneralInformationId { get; set; }
        public GeneralInformation GeneralInformation { get; set; }

        public Worker Workers { get; set; }

        public CPU CPU { get; set; }

        public MB MB { get; set; }

        public OS OS { get; set; }

        public VideoCard VideoCard { get; set; }

        public RAM RAM { get; set; }

        public DataStorage DataStorage { get; set; }
    }
}
