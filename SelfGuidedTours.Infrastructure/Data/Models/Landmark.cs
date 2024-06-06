using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfGuidedTours.Infrastructure.Data.Models
{
    public class Landmark
    {
        [Key]
        public int LandmarkId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }
        public string History { get; set; }

        [Required]
        public int CoordinateId { get; set; }
        [ForeignKey(nameof(CoordinateId))]
        public Coordinate Coordinate { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<TourLandmark> TourLandmarks { get; set; } = new HashSet<TourLandmark>();
    }
}
