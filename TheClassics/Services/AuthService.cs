using Microsoft.EntityFrameworkCore;
using TheClassics.Data;
using TheClassics.Models;

namespace TheClassics.Services
{
    public class AuthService
    {
        private readonly ApplicationDbContext _db;

        public AuthService(ApplicationDbContext db)
            => _db = db;

        /// <summary>
        /// The currently logged in user, or null.
        /// </summary>
        public User? CurrentUser { get; private set; }

        /// <summary>
        /// Fires whenever CurrentUser changes (login/logout).
        /// </summary>
        public event Action? AuthStateChanged;

        /// <summary>
        /// Attempts to register a new user. Returns false if username or email already exists.
        /// </summary>
        public async Task<bool> RegisterAsync(string username, string email, string password)
        {
            // check uniqueness
            var exists = await _db.Users
                .AnyAsync(u => u.Username == username || u.Email == email);

            if (exists) 
                return false;

            // create & save
            var user = new User
            {
                Username     = username,
                Email        = email,
                PasswordHash = HashPassword(password),
                IsAdmin      = false
            };

            _db.Users.Add(user);
            await _db.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// Checks credentials and logs you in.
        /// </summary>
        public async Task<bool> LoginAsync(string username, string password)
        {
            var hash = HashPassword(password);
            var user = await _db.Users
                .SingleOrDefaultAsync(u => u.Username == username && u.PasswordHash == hash);

            if (user == null) 
                return false;

            CurrentUser = user;
            AuthStateChanged?.Invoke();
            return true;
        }

        /// <summary>
        /// Clears CurrentUser.
        /// </summary>
        public void Logout()
        {
            CurrentUser = null;
            AuthStateChanged?.Invoke();
        }

        /// <summary>
        /// SHA-256 + Base64.
        /// </summary>
        public static string HashPassword(string pw)
        {
            using var sha = System.Security.Cryptography.SHA256.Create();
            var bytes = System.Text.Encoding.UTF8.GetBytes(pw);
            var hash  = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
