using MagicVilla.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Huge villa",
                    ImageUrl= "https://pngtree.com/so/villa",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate= DateTime.Now,
                },
                new Villa()
                {
                    Id= 2,
                    Name="Premium Pool Villa",
                    Details="Extra ordinary villa",
                    ImageUrl = "https://pngtree.com/so/villa",
                    Occupancy = 4,
                    Rate =600,
                    Sqft=550,
                    Amenity="",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id= 3,
                    Name="Luxury Pool Villa",
                    Details="Very huge pool villa",
                    ImageUrl = "https://pngtree.com/so/villa",
                    Occupancy = 4,
                    Rate=400,
                    Sqft=440,
                    Amenity="",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id= 4,
                    Name="Diamond Villa",
                    Details="Very rare enjoyable villa",
                    ImageUrl = "https://pngtree.com/so/villa",
                    Occupancy = 4,
                    Rate=200,
                    Sqft=500,
                    Amenity="",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id= 5,
                    Name="Diamond Pool Villa",
                    Details="8-10 people can stay",
                    ImageUrl = "https://pngtree.com/so/villa",
                    Occupancy = 5,
                    Rate=600,
                    Sqft=700,
                    Amenity="",
                    CreatedDate = DateTime.Now
                });
        }
    }
}
