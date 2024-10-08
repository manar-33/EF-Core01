﻿// <auto-generated />
using System;
using EF_Core01.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_Core01.Migrations
{
    [DbContext(typeof(ITIDbContext))]
    [Migration("20240829160819_Second")]
    partial class Second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_Core01.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<double>("Duration")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Top_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EF_Core01.Entities.Course_Inst", b =>
                {
                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<int>("Inst_Id")
                        .HasColumnType("int");

                    b.Property<double>("Evaluate")
                        .HasColumnType("float");

                    b.HasKey("Course_Id", "Inst_Id")
                        .HasName("PK_Course_Inst");

                    b.ToTable("Course_Insts");
                });

            modelBuilder.Entity("EF_Core01.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Inst_Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("MyDepartments");
                });

            modelBuilder.Entity("EF_Core01.Entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<double>("Bounce")
                        .HasColumnType("float");

                    b.Property<int>("Dept_Id")
                        .HasColumnType("int");

                    b.Property<double>("HourRate")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("EF_Core01.Entities.Stud_Course", b =>
                {
                    b.Property<int>("Stud_Id")
                        .HasColumnType("int");

                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.HasKey("Stud_Id", "Course_Id")
                        .HasName("PK_Stud_Course");

                    b.ToTable("Stud_Courses");
                });

            modelBuilder.Entity("EF_Core01.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Dep_Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EF_Core01.Entities.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Topics");
                });
#pragma warning restore 612, 618
        }
    }
}
