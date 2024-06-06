using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfGuidedTours.Infrastructure.Data.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Required]
        public int WalletId { get; set; }
        [ForeignKey(nameof(WalletId))]
        public Wallet Wallet { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; } = DateTime.Now;

        [Required]
        public string TransactionType { get; set; } = null!; // Should be 'deposit' or 'withdrawal' could be a enum
    }
}
