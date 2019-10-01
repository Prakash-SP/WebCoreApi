using coreWebApiTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreWebApiTest.Context
{
    public class EmployeeContext:DbContext
    {
        private readonly IConfiguration _configuration;
        public EmployeeContext(IConfiguration configuration,DbContextOptions options):base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Company> Company { get; set; }
        public DbSet<Employee> Employees { get; set;}
        public DbSet<Office> Offices { get; set; }
        public DbSet<JobDes> JobDes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Employee"));
        }


        //-----Automatic Data Insertion(SEEDING) on Database and Table Creation------

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Employee>()
        //        .HasData(new
        //        {
        //            Name = "Ajay",
        //            Dob = new DateTime(1996, 06, 26),
        //            Gender = "Male",
        //            Email = "abc@xyz.com",
        //            JobId = 1,
        //            MobileNo = 9708451257
        //        });
        //    builder.Entity<Office>()
        //        .HasData(new
        //        {
        //            OfficeId = 1,
        //            Name="GGNOffice",
        //            City="Gurugram",
        //            State="Haryana",
        //            ZipCode=122001
        //        });
        //}
    }
}
