using Microsoft.EntityFrameworkCore;
using MinhaSeries.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSeries.Infrastructure
{
    public class MinhaSeriesDbContext : DbContext
    {
        public MinhaSeriesDbContext(DbContextOptions<MinhaSeriesDbContext> options) : base(options)
        {
        }
        public DbSet<Serie> Series { get; set; }
        public DbSet<SerieComment> SeriesComments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
