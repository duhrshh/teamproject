using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheClassics.Models
{
    /// <summary>
    /// Represents a vinyl item in inventory.
    /// </summary>
    public class InventoryItem
    {
        [Key]
        public int ItemId { get; set; }

        public int? OrderId { get; set; }
        public Order Order  { get; set; } = null!;

        [Required, StringLength(100)]
        public string Name { get; set; } = null!;

        [StringLength(255)]
        public string Description { get; set; } = null!;

        [Column(TypeName = "REAL")]
        public double Price { get; set; }

        [StringLength(255)]
        public string ImageUrl { get; set; } = null!;

        public bool IsSold { get; set; }
    }
}