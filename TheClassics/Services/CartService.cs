using System.ComponentModel.DataAnnotations;
using TheClassics.Models;

namespace TheClassics.Services
{
    /// <summary>
    /// Manages the user’s shopping cart and pending order info.
    /// </summary>
    public class CartService
    {
        // ──── Your existing cart ─────────────────────────────────────────────────
        public List<InventoryItem> Cart { get; } = new();

        // ──── Pending order input ────────────────────────────────────────────────
        /// <summary>
        /// Holds all the fields the user fills in on the Payment page.
        /// </summary>
        public OrderInput PendingOrderInput { get; private set; } = new();

        /// <summary>
        /// Call this when the Payment form is submitted.
        /// </summary>
        public void SetOrderInput(OrderInput input)
            => PendingOrderInput = input;

        // ──── Totals, shipping & tax ──────────────────────────────────────────────
        public string ShippingOption => PendingOrderInput.ShippingSpeed;

        public double Subtotal    => Cart.Sum(i => i.Price);
        public double Tax         => Math.Round(Subtotal * 0.06, 2);
        public double ShippingCost => ShippingOption switch
        {
            "Overnight" => 29,
            "ThreeDay"  => 19,
            _           => 0
        };
        public double Total       => Subtotal + Tax + ShippingCost;

        // ──── Cart operations ─────────────────────────────────────────────────────
        public void Add(InventoryItem item)
        {
            if (!Cart.Contains(item) && !item.IsSold)
                Cart.Add(item);
        }

        public void Remove(InventoryItem item)
            => Cart.Remove(item);

        public void ClearCart()
            => Cart.Clear();

        // ──── DTO for collecting Payment page inputs ──────────────────────────────
        public class OrderInput
        {
            [Required, StringLength(255)]
            public string ShippingAddress { get; set; } = string.Empty;

            [Required, Phone]
            public string Phone { get; set; } = string.Empty;

            [Required, MinLength(13), MaxLength(19)]
            public string CreditCardNumber { get; set; } = string.Empty;

            [Required]
            public string ShippingSpeed { get; set; } = "Ground";
        }
    }
}
