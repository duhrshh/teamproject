using Microsoft.EntityFrameworkCore;
using TheClassics.Models;
using TheClassics.Services; 


namespace TheClassics.Data
{
    /// <summary>
    /// Seeds the database with initial data.
    /// </summary>
    public class DbInitializer
    {
        private readonly ApplicationDbContext _context;

        public DbInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Applies any pending migrations and seeds admin, guest, and sample inventory.
        /// </summary>
        public async Task SeedAsync()
        {
            await _context.Database.MigrateAsync();

            if (!_context.Users.Any())
            {
                SeedUsers();
                SeedInventory();
                await _context.SaveChangesAsync();
            }
        }

        private void SeedUsers()
        {
            _context.Users.Add(new User
            {
                Username     = "admin",
                Email        = "admin@theclassics.com",
                PasswordHash = AuthService.HashPassword("Admin#123"),
                IsAdmin      = true
            });

            _context.Users.Add(new User
            {
                Username     = "guest",
                Email        = "guest@theclassics.com",
                PasswordHash = AuthService.HashPassword("Guest#123"),
                IsAdmin      = false
            });
        }

        private void SeedInventory()
        {
            _context.InventoryItems.AddRange(
                new InventoryItem
                {
                    Name        = "Abbey Road",
                    Description = "The Beatles – 1969 classic",
                    Price       = 29.99,
                    ImageUrl    = "/images/abbey_road.jpg",
                    IsSold      = false
                },
                new InventoryItem
                {
                    Name        = "Rumours",
                    Description = "Fleetwood Mac – 1977 hit",
                    Price       = 24.99,
                    ImageUrl    = "/images/rumours.jpg",
                    IsSold      = false
                },
            new InventoryItem
                {
                    Name        = "Fly me to the Moon",
                    Description = "Frank Sinatra – 2008 Remastered",
                    Price       = 19.99,
                    ImageUrl    = "/images/Fly_Me_To_The_Moon.png",
                    IsSold      = false
                },
            new InventoryItem
            {
                Name        = "My Way",
                Description = "Frank Sinatra - 1969 classic",
                Price       = 24.99,
                ImageUrl    = "/images/FS-My_Way.png",
                IsSold      = false
            },
            new InventoryItem
            {
                Name        = "Thriller",
                Description = "Michael Jackson - 1982",
                Price       = 29.99,
                ImageUrl    = "/images/MJ-Thriller.jpeg",
                IsSold      = false
            },
            new InventoryItem
            {
                Name        = "Smooth Criminal",
                Description = "Michael Jackson - 1988",
                Price       = 24.99,
                ImageUrl    = "/images/MJ-Smooth_Criminal.jpeg",
                IsSold      = false
            },
            new InventoryItem
            {
                Name        = "It's Beginning to look a lot like Christmas",
                Description = "Michael Bublé - 2021",
                Price       = 14.99,
                ImageUrl    = "/images/MB-Christmas.png",
                IsSold      = false
            },
            new InventoryItem
            {
                Name        = "Feeling Good",
                Description = "Michael Bublé - 2010",
                Price       = 14.99,
                ImageUrl    = "/images/MB-Feeling_Good.png",
                IsSold      = false
            },
            new InventoryItem
            {
                Name        = "Sway",
                Description = "Michael Bublé - 2024",
                Price       = 19.99,
                ImageUrl    = "/images/MB-Sway.jpeg",
                IsSold      = false
            },
            new InventoryItem
            {
                Name        = "Higher",
                Description = "Michael Bublé - 2022",
                Price       = 19.99,
                ImageUrl    = "/images/MB-Higher.jpeg",
                IsSold      = false
            },
            new InventoryItem
            {
                Name        = "Spicy Margarita",
                Description = "Jason Derulo & Michael Bublé - 2024",
                Price       = 19.99,
                ImageUrl    = "/images/MB_JD-Spicy_M.png",
                IsSold      = false
            },
            new InventoryItem
            {
                Name        = "Dark Side of the Moon",
                Description = "Pink Floyd - 1973",
                Price       = 29.99,
                ImageUrl    = "/images/darkside.jpg",
                IsSold      = false
            }
            );
        }
    }
}
