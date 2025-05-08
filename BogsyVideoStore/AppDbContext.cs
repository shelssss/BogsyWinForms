using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BogsyVideoStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BogsyVideoStore
{
    public class AppDbContext:DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Video> Video { get; set; } 
        public DbSet<CustomerRented> CustomerRented { get; set; }
        public DbSet<RentedVideo> RentedVideos { get; set; }
        public DbSet<CustomerQueries> CustomerQueries { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-A14OUSM\\SQLEXPRESS;Database=Bogsy;Trusted_Connection=True;MultipleActiveResultSets=true;trustservercertificate=true");
        }
    }
}
