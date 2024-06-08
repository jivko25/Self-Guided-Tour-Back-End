using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SelfGuidedTours.Infrastructure.Data.Models
{
    public class TourLandmark
    {
        [Required]
        public int TourId { get; set; }
        [ForeignKey(nameof(TourId))]
        public Tour Tour { get; set; } = null!;

       [Required]
        public int LandmarkId { get; set; }
        [ForeignKey(nameof(LandmarkId))]
        public Landmark Landmark { get; set; } = null!;

        [Required]
        public int StopOrder { get; set; }
    }
}
