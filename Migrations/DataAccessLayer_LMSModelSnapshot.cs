﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi_LMS_Team3.DataAccessLayer;

namespace WebApi_LMS_Team3.Migrations
{
    [DbContext(typeof(DataAccessLayer_LMS))]
    partial class DataAccessLayer_LMSModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebApi_LMS_Team3.Model.EmployeeDb", b =>
                {
                    b.Property<int>("Emp_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Emp_City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Emp_DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Emp_Dept")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emp_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emp_Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Emp_Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("Emp_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Emp_Salary")
                        .HasColumnType("bigint");

                    b.HasKey("Emp_Id");

                    b.ToTable("Employee_T");
                });
#pragma warning restore 612, 618
        }
    }
}
