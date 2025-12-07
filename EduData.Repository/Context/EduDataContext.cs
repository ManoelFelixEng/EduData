using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EduData.Repository.Mapping;
using EduData.Domain.Entities;

namespace EduData.Repository.Context
{
    public class EduDataContext : DbContext
    {
        public EduDataContext(DbContextOptions<EduDataContext> op = null) : base(op)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=IFSPStore;user=root;password=");
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<College_Subject> CollegeSubjects { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.Entity<Class>(new ClassMap().Configure);
            modelBuilder.Entity<Student>(new StudentMap().Configure);t
            modelBuilder.Entity<College_Subject>(new College_SubjectMap().Configure);
            modelBuilder.Entity<Enrollment>(new EnrollmentMap().Configure);
            modelBuilder.Entity<Evaluation>(new EvaluationMap().Configure);

        }

    }
}