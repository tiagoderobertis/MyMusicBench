using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyMusicBench.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicBench.Connection
{
    public  class MyMusicBenchContext : DbContext
    {
        

        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data source=MyMusicBench.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
