using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Webapplication6.Models
{
    public partial class InformationContext : DbContext
    {
        public InformationContext()
        {
        }

        public InformationContext(DbContextOptions<InformationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Departmentppl> Departmentppls { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee2> Employee2s { get; set; }
        public virtual DbSet<Employeetable> Employeetables { get; set; }
        public virtual DbSet<Table1p> Table1ps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-VI23QLJ7\\MSSQLESERVER3;Initial Catalog=Information;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("department");

                entity.Property(e => e.Department1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("department");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Departmentppl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("departmentppl");

                entity.Property(e => e.Department)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("department");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employee");

                entity.Property(e => e.Departmentid).HasColumnName("departmentid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Employee2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employee2");

                entity.Property(e => e.Departmentid).HasColumnName("departmentid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Employeetable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employeetable");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(10)
                    .HasColumnName("first name")
                    .IsFixedLength(true);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .HasColumnName("gender")
                    .IsFixedLength(true);

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("id")
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(10)
                    .HasColumnName("last name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Table1p>(entity =>
            {
                entity.ToTable("Table_1p");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("id")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
