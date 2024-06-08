using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfGuidedTours.Infrastructure.Data.Models
{
    public class Coordinate
    {
        [Key]
        public int CoordinateId { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Latitude { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Longitude { get; set; }
    }
}
