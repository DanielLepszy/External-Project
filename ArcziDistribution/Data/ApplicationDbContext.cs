using System;
using System.Collections.Generic;
using System.Text;
using DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArcziDistribution.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AutoClientDatabase;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }

        public DbSet<Accounts> Account { get; set; }
        public DbSet<Customers> Course { get; set; }
        public DbSet<Vehicles> Exam { get; set; }
        public DbSet<Services> OpenedQuestion { get; set; }
        public DbSet<Reminders> ClosedQuestion { get; set; }
  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new AccountConfiguration());
            //modelBuilder.ApplyConfiguration(new CourseConfiguration());
            //modelBuilder.ApplyConfiguration(new ExamClosedQuestionsConfiguration());
            //modelBuilder.ApplyConfiguration(new ExamOpenedQuestionsConfiguration());
            //modelBuilder.ApplyConfiguration(new ResultsConfiguration());
        }
    }
}
