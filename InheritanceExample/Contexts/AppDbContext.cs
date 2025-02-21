using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceExample.Models;
using Microsoft.EntityFrameworkCore;

namespace InheritanceExample.Contexts
{
    internal class AppDbContext :DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TPH Configuration.....
            //modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
            //modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // TPC Configuration
            //modelBuilder.Entity<Employee>().ToTable("Employees");
            //modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployee");
            //modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployee");
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // TPCC Configuration
            

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = Shimaa123 ; Database = InheritanceDB03; Trusted_Connection = True ; TrustServerCertificate = True");
        }
       
        //public DbSet<Employee> employees { get; set; }
        public DbSet<FullTimeEmployee> fulltimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> parttimeEmployees { get; set; }
    }
}
