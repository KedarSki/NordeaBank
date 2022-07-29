using Microsoft.EntityFrameworkCore;
using NordeaBank.Api.Entities;

namespace NordeaBank.Api.Data
{
    public class NordeaBankDbContext : DbContext
    {
        public NordeaBankDbContext(DbContextOptions<NordeaBankDbContext> options):base(options)
        
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Worker>().HasData(
                new Worker
                {
                    Id = 1,
                    First_Name = "Monika",
                    Last_Name = "Arora",
                    Salary = 10000,
                    Joining_Date = new DateTime(2014, 02, 20, 09, 00, 00),
                    Department = "HR"
                });

            modelBuilder.Entity<Worker>().HasData(
                new Worker
                {
                    Id = 2,
                    First_Name = "Niharika",
                    Last_Name = "Verma",
                    Salary = 80000,
                    Joining_Date = new DateTime(2014, 06, 11, 09, 00, 00),
                    Department = "Admin"
                });

            modelBuilder.Entity<Worker>().HasData(
                new Worker
                {
                    Id = 3,
                    First_Name = "Vishal",
                    Last_Name = "Singhal",
                    Salary = 300000,
                    Joining_Date = new DateTime(2014, 02, 20, 09, 00, 00),
                    Department = "HR"
                });

            modelBuilder.Entity<Worker>().HasData(
                new Worker
                {
                    Id = 4,
                    First_Name = "Amitabh",
                    Last_Name = "Singh",
                    Salary = 500000,
                    Joining_Date = new DateTime(2014, 02, 20, 09, 00, 00),
                    Department = "Admin"
                });

            modelBuilder.Entity<Worker>().HasData(
                new Worker
                {
                    Id = 5,
                    First_Name = "Vivek",
                    Last_Name = "Bhati",
                    Salary = 500000,
                    Joining_Date = new DateTime(2014, 06, 11, 09, 00, 00),
                    Department = "Admin"
                });


            modelBuilder.Entity<Worker>().HasData(
                new Worker
                {
                    Id = 6,
                    First_Name = "Vipul",
                    Last_Name = "Diwan",
                    Salary = 200000,
                    Joining_Date = new DateTime(2014, 06, 11, 09, 00, 00),
                    Department = "Account"
                });

            modelBuilder.Entity<Worker>().HasData(
                new Worker
                {
                    Id = 7,
                    First_Name = "Satish",
                    Last_Name = "Kumar",
                    Salary = 7500,
                    Joining_Date = new DateTime(2014, 01, 20, 09, 00, 00),
                    Department = "Account"
                });

            modelBuilder.Entity<Worker>().HasData(
                new Worker
                {
                    Id = 8,
                    First_Name = "Geetika",
                    Last_Name = "Chauhan",
                    Salary = 90000,
                    Joining_Date = new DateTime(2014, 04, 11, 09, 00, 00),
                    Department = "Admin"
                });

            modelBuilder.Entity<Title>().HasData(
                new Title
                {
                    Id = 1,
                    Worker_Ref_Id = 1,
                    Worker_Title = "Manager",
                    Affected_From = new DateTime(2016, 02, 20, 00, 00, 00)
                });


            modelBuilder.Entity<Title>().HasData(
                new Title
                {
                    Id = 2,
                    Worker_Ref_Id = 2,
                    Worker_Title = "Executive",
                    Affected_From = new DateTime(2016, 06, 11, 00, 00, 00)
                });


            modelBuilder.Entity<Title>().HasData(
                new Title
                {
                    Id = 3,
                    Worker_Ref_Id = 8,
                    Worker_Title = "Executive",
                    Affected_From = new DateTime(2016, 06, 11, 00, 00, 00)
                });


            modelBuilder.Entity<Title>().HasData(
                new Title
                {

                    Id = 4,
                    Worker_Ref_Id = 5,
                    Worker_Title = "Manager",
                    Affected_From = new DateTime(2016, 02, 20, 00, 00, 00)
                });


            modelBuilder.Entity<Title>().HasData(
                new Title
                {   
                    Id = 5,
                    Worker_Ref_Id = 4,
                    Worker_Title = "Asst. Manager",
                    Affected_From = new DateTime(2016, 02, 20, 00, 00, 00)
                });


            modelBuilder.Entity<Title>().HasData(
                new Title
                {
                    Id = 6, 
                    Worker_Ref_Id = 7,
                    Worker_Title = "Executive",
                    Affected_From = new DateTime(2016, 02, 20, 00, 00, 00)
                });


            modelBuilder.Entity<Title>().HasData(
                new Title
                {
                    Id = 7,
                    Worker_Ref_Id = 6,
                    Worker_Title = "Lead",
                    Affected_From = new DateTime(2016, 02, 20, 00, 00, 00)
                });


            modelBuilder.Entity<Title>().HasData(
                new Title
                { 
                    Id= 8,
                    Worker_Ref_Id = 3,
                    Worker_Title = "Lead",
                    Affected_From = new DateTime(2016, 02, 20, 00, 00, 00)
                });


        }

/*        public DbSet<Title> Titles { get; set; }

        public DbSet<Worker> Workers { get; set; }*/

    }
}
