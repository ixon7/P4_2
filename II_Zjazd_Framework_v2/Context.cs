using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace II_Zjazd_Framework_v2
{
    public class Context : DbContext
    {
        public DbSet<Zajecia> Zajecias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=EFCF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        // Fluen albo adnotacje
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Zajecia>().HasKey(x => x.Id);
        //    modelBuilder.Entity<Zajecia>().Property(x => x.Nazwa).IsRequired();
        //}
    }
}
