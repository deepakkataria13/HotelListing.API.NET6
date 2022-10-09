using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "India",
                    ShortName = "IN"
                },
                new Country { Id = 2, Name = "St.Kitts and Nevis", ShortName = "ST" }
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "The leela Internation",
                    Address = "New Delhi",
                    CountryId = 1,
                    Ratings = 4.9
                },
                new Hotel { Id = 2, Name = "JW Marriott", Address = "Saint Kitts", CountryId = 2, Ratings = 4.7 }
                );
        }
    }
}
