using System.ComponentModel.DataAnnotations;

namespace TheClassics.Models
{
    /// <summary>
    /// Represents an application user.
    /// </summary>
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; } = null!;

        // SHA-256 hex digest length = 64 chars
        [Required, StringLength(64)]
        public string PasswordHash { get; set; } = null!;

        [Required, EmailAddress, StringLength(100)]
        public string Email { get; set; } = null!;

        public bool IsAdmin { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}