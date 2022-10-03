using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bire_Cok_Iliski
{
   public class DBXContext:DbContext
    {
        public DbSet<PcMarkalar> PcMarkalar { get; set; }
        public DbSet<Kisiler> Kisiler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PcMarkaKisi;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kisiler>()
                .HasKey(u=>new { u.KisilerID, u.KISIAD });

            modelBuilder.Entity<PcMarkalar>()
                .HasKey(x => x.MarkaID);

            modelBuilder.Entity<Kisiler>()
                .HasOne(x => x.PcMarkalar)
                .WithMany(x => x.Kisiler)
                .HasForeignKey(x => x.PCMarkaID);
        }
    }
}
