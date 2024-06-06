using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfGuidedTours.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Credentials { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public virtual ICollection<Tour> CreatedTours { get; set; } = new HashSet<Tour>();
        public virtual ICollection<Payment> Payments { get; set; } = new HashSet<Payment>();
        public virtual ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
        public virtual ICollection<ApplicationUserTour> UserTours { get; set; } = new HashSet<ApplicationUserTour>();
        public Wallet Wallet { get; set; }
    }
}
