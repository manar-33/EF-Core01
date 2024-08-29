using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Core01.Confgrations;
using EF_Core01.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_Core01.Contexts
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        
            modelBuilder.ApplyConfiguration(new Stud_CourseConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfigration());
        
        modelBuilder.Entity<Course>(C =>
            {
                C.HasKey(C => C.Id);
                C.Property(C => C.Description)
                .HasColumnType("varchar")
                .HasMaxLength(50);
            });

            modelBuilder.Entity<Instructor>(Inst =>
            {
                Inst.HasKey(Inst => Inst.Id);
                Inst.Property(Inst => Inst.Address)
                .HasColumnType("varchar")
                .HasMaxLength(50);
            }
            );
            modelBuilder.Entity<Course_Inst>(CI =>
            {
                CI.HasKey(CI => new { CI.Course_Id, CI.Inst_Id })
                .HasName("PK_Course_Inst");
            });


            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = ITIDb; Trusted_Connection = True;Encrypt=True;TrustServerCertificate=True");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}
