using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Server1.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Directors> Directors { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Exams> Exams { get; set; }
        public virtual DbSet<Grades> Grades { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<HomeTask> HomeTask { get; set; }
        public virtual DbSet<Parents> Parents { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Timetable> Timetable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Groups>()
                .HasMany(e => e.Exams)
                .WithRequired(e => e.Groups)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Groups>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Groups)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Groups>()
                .HasMany(e => e.Timetable)
                .WithRequired(e => e.Groups)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Parents>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Parents>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Students>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Students>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Students>()
                .HasMany(e => e.Attendance)
                .WithRequired(e => e.Students)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Students>()
                .HasMany(e => e.HomeTask)
                .WithRequired(e => e.Students)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subjects>()
                .HasMany(e => e.Exams)
                .WithRequired(e => e.Subjects)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subjects>()
                .HasMany(e => e.Grades)
                .WithRequired(e => e.Subjects)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subjects>()
                .HasMany(e => e.HomeTask)
                .WithRequired(e => e.Subjects)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subjects>()
                .HasMany(e => e.Timetable)
                .WithRequired(e => e.Subjects)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teachers>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Teachers>()
                .HasMany(e => e.Timetable)
                .WithRequired(e => e.Teachers)
                .WillCascadeOnDelete(false);
        }
    }
}
