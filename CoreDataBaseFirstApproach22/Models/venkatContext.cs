using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreDataBaseFirstApproach22.Models
{
    public partial class venkatContext : DbContext
    {
        public venkatContext()
        {
        }

        public venkatContext(DbContextOptions<venkatContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public virtual DbSet<Patient1> Patient1s { get; set; } = null!;
        public virtual DbSet<Register> Registers { get; set; } = null!;
        public virtual DbSet<UserLogin> UserLogins { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptId);

                entity.ToTable("Department");

                entity.Property(e => e.Dlocation).HasMaxLength(50);

                entity.Property(e => e.Dname).HasMaxLength(50);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .HasColumnName("employee_Name");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.PatientName)
                    .HasMaxLength(50)
                    .HasColumnName("patient_Name");
            });

            modelBuilder.Entity<Patient1>(entity =>
            {
                entity.ToTable("Patient1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.PatientName)
                    .HasMaxLength(50)
                    .HasColumnName("patient_Name");
            });

            modelBuilder.Entity<Register>(entity =>
            {
                entity.ToTable("Register");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .HasColumnName("Phone_Number");

                entity.Property(e => e.ResetpasswordCode).HasMaxLength(100);
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserLogi__1788CC4C7B81DFFF");

                entity.ToTable("UserLogin");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Token).HasMaxLength(50);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
