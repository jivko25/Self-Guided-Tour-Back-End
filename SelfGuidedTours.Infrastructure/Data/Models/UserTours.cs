using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfGuidedTours.Infrastructure.Data.Models
{
    public class UserTours
    {
        [Required]
        [Key]
        public int UserTourId { get; set; }

        public string UserId { get; set; } = null!;
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        public int TourId { get; set; }
        [ForeignKey(nameof(TourId))]
        public Tour Tour { get; set; } = null!;

        [Required]
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
    }
}
