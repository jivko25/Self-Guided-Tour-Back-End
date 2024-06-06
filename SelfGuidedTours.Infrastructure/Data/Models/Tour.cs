using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SelfGuidedTours.Infrastructure.Data.Models
{
    public class Tour
    {
        [Key]
        public int TourId { get; set; }

        [Required]
        public string CreatorId { get; set; } = null!;
        [ForeignKey("Creator")]
        public ApplicationUser Creator { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }

        public int? StartCoordinateId { get; set; }
        [ForeignKey(nameof(StartCoordinateId))]
        public Coordinate StartCoordinate { get; set; } = null!;

        public int? EndCoordinateId { get; set; }
        [ForeignKey(nameof(EndCoordinateId))]
        public Coordinate EndCoordinate { get; set; } = null!;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<TourLandmark> TourLandmarks { get; set; } = new HashSet<TourLandmark>();
        public virtual ICollection<Payment> Payments { get; set; } = new HashSet<Payment>();
        public virtual ICollection<Review> Reviews { get; set; }  = new HashSet<Review>();
        public virtual ICollection<ApplicationUserTour> UserTours { get; set; } = new HashSet<ApplicationUserTour>();
    }
}