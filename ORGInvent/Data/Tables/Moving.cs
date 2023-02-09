using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ORGInvent.Data.Tables
{
    [Table("Moving")]
    public class Moving
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public User User { get; set; }

        public Equipment Equipment { get; set; }

        public Worker Worker { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public TypeOfWorkMoving TypeOfWork { get; set; }
    }
}
