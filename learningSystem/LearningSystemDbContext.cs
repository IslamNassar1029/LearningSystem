using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Entities;

namespace WinFormsApp1
{
    public class LearningSystemDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=LearningSystem;Trusted_connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Student
            modelBuilder.Entity<Student>()
                .Property(s => s.FirstName).HasColumnType("varchar(255)");
            modelBuilder.Entity<Student>()
                .Property(s => s.LastName).HasColumnType("varchar(255)");
            modelBuilder.Entity<Student>()
                .Property(s => s.Phone).HasColumnType("varchar(255)");
            modelBuilder.Entity<Student>()
                .HasMany<CourseStudent>()
                .WithOne(cs=>cs.Student)
                .HasForeignKey(cs => cs.StudentId);
            modelBuilder.Entity<Student>()
                .HasMany<CourseSessionAttendance>()
                .WithOne(cs => cs.Student)
                .HasForeignKey(cs => cs.StudentId);

            //Instructor
            modelBuilder.Entity<Instructor>()
                .Property(s => s.FirstName).HasColumnType("varchar(255)");
            modelBuilder.Entity<Instructor>()
                .Property(s => s.LastName).HasColumnType("varchar(255)");
            modelBuilder.Entity<Instructor>()
                .Property(s => s.Phone).HasColumnType("varchar(255)");
            modelBuilder.Entity<Instructor>()
                .HasMany(i => i.Instructors)
                .WithOne(i => i.Headed)
                .HasForeignKey(i => i.HeadedBy);
            modelBuilder.Entity<Instructor>()
                .HasMany<CourseSession>()
                .WithOne(cs=>cs.Instructor)
                .HasForeignKey(cs => cs.InstructorId);

            //Department
            modelBuilder.Entity<Department>()
                .HasKey(d => d.Name);
            modelBuilder.Entity<Department>()
                .Property(d => d.Name).HasColumnType("varchar(255)");
            modelBuilder.Entity<Department>()
                .Property(d => d.Location).HasColumnType("varchar(255)");
            modelBuilder.Entity<Department>()
               .HasMany(d => d.Instructers)
               .WithOne(i => i.Department)
               .HasForeignKey(i => i.DepartmentName);


            //Course
            modelBuilder.Entity<Course>()
                .Property(s => s.Name).HasColumnType("varchar(255)");
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Department)
                .WithMany(d => d.Courses)
                .HasForeignKey(c => c.DepartmentName);
            modelBuilder.Entity<Course>()
               .HasOne(c => c.Instructor)
               .WithMany(d => d.Courses)
               .HasForeignKey(c => c.InstructorId)
               .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Course>()
                .HasMany<CourseStudent>()
                .WithOne(cs => cs.Course)
                .HasForeignKey(cs => cs.CourseId);
            modelBuilder.Entity<Course>()
              .HasMany<CourseSession>()
              .WithOne(cs => cs.Course)
              .HasForeignKey(cs => cs.CourseId)
              .OnDelete(DeleteBehavior.Restrict);


            //CourseStudent
            modelBuilder.Entity<CourseStudent>()
                .HasKey(cs =>new { cs.CourseId ,cs.StudentId});

            //CourseSessionAttendance
            modelBuilder.Entity<CourseSessionAttendance>()
              .Property(csa => csa.Notes).HasColumnType("varchar(255)");

            //CourseSession
            modelBuilder.Entity<CourseSession>()
           .Property(cs => cs.Date)
           .HasColumnType("date")
           .IsRequired();
            modelBuilder.Entity<CourseSession>()
           .Property(d => d.Title).HasColumnType("varchar(255)");
            modelBuilder.Entity<CourseSession>()
            .HasMany<CourseSessionAttendance>()
            .WithOne(cse => cse.CourseSession)
            .HasForeignKey(cs => cs.CourseSessionId);

            //foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            //{
            //    relationship.DeleteBehavior = DeleteBehavior.Restrict;
            //}
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseSession> CourseSessions { get; set; }
        public DbSet<CourseSessionAttendance> CourseSessionAttendances { get; set; }
        public DbSet<CourseStudent> CourseStudents { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
