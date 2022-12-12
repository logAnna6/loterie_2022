using System;
using System.Reflection.Metadata;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Game> Games { get; set; }

        public DbSet<Player> Players { get; set; }
    }


}
