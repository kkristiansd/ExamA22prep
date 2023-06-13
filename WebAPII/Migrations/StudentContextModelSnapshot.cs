﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPII.Data;

#nullable disable

namespace WebAPII.Migrations
{
    [DbContext(typeof(StudentContext))]
    partial class StudentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Data.GradeInCourse", b =>
                {
                    b.Property<string>("CourseCode")
                        .HasMaxLength(4)
                        .HasColumnType("TEXT");

                    b.Property<int>("Grade")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("studentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CourseCode");

                    b.HasIndex("studentId");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("Data.Student", b =>
                {
                    b.Property<int>("studentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("Programme")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("studentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Data.GradeInCourse", b =>
                {
                    b.HasOne("Data.Student", null)
                        .WithMany("GradeInCourses")
                        .HasForeignKey("studentId");
                });

            modelBuilder.Entity("Data.Student", b =>
                {
                    b.Navigation("GradeInCourses");
                });
#pragma warning restore 612, 618
        }
    }
}