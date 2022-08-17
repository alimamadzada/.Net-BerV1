using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Beryllium.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<ArchitectureImage> ArchitectureImages { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
