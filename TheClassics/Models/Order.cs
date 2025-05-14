using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheClassics.Models
{
    /// <summary>
    /// Represents a purchase order.
    /// </summary>
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User   { get; set; } = null!;

        [Required, StringLength(255)]
        public string ShippingAddress { get; set; } = null!;

        [Required, Phone, StringLength(15)]
        public string Phone { get; set; } = null!;

        [Column(TypeName = "char(4)")]
        public string CreditCardLast4 { get; set; } = null!;

        [Required, StringLength(15)]
        public string ShippingSpeed { get; set; } = null!; 
 
        [Column(TypeName = "REAL")]
        public double Subtotal { get; set; }

        [Column(TypeName = "REAL")]
        public double Tax { get; set; }

        [Column(TypeName = "REAL")]
        public double ShippingCost { get; set; }

        [Column(TypeName = "REAL")]
        public double Total { get; set; }

        public DateTime OrderDate { get; set; }

        public ICollection<InventoryItem> InventoryItems { get; set; } 
            = new List<InventoryItem>();
    }
}