using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SelfGuidedTours.Infrastructure.Data.Models
{
    public class Landmark
    {
        [Key]
        public int LandmarkId { get; set; }

        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        public string History { get; set; } = null!;

        [Required]
        public int CoordinateId { get; set; }
        [ForeignKey(nameof(CoordinateId))]
        public Coordinate Coordinate { get; set; } = null!;

        public string? ImageUrl { get; set; }
        public string? VideoUrl { get; set; }

        public virtual ICollection<TourLandmark> TourLandmarks { get; set; } = new HashSet<TourLandmark>();
    }
}
