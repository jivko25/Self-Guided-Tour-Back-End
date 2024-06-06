using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SelfGuidedTours.Infrastructure.Data.Models
{
    public class UserTour
    {
        [Required]
        public int UserTourId { get; set; }

        [ForeignKey(nameof(UserTourId))]
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }

        [Required]
        [ForeignKey("Tour")]
        public int TourId { get; set; }
        public Tour Tour { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
    }
}