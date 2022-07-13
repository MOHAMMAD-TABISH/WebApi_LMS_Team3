﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi_LMS_Team3.DataAccessLayer;

namespace WebApi_LMS_Team3.Migrations
{
    [DbContext(typeof(DataAccessLayer_LMS))]
    [Migration("20220713114454_initEmp")]
    partial class initEmp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebApi_LMS_Team3.Model.ApplyLeaveDb", b =>
                {
                    b.Property<int>("Emp_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("AppliedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LeaveReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeaveStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeaveType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mng_Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoOfDays")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Emp_Id");

                    b.ToTable("ApplyLeave_T");
                });

            modelBuilder.Entity("WebApi_LMS_Team3.Model.EmpLeaveStatusDb", b =>
                {
                    b.Property<int>("Leave_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LeaveReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeaveStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeaveType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoOfDays")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Leave_Id");

                    b.ToTable("EmpLeaveStatus_T");
                });

            modelBuilder.Entity("WebApi_LMS_Team3.Model.EmployeeDb", b =>
                {
                    b.Property<int>("Emp_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<long>("Available_Leave")
                        .HasColumnType("bigint");

                    b.Property<string>("Emp_Dept")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emp_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Emp_Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("Emp_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Emp_Id");

                    b.ToTable("Employee_T");
                });

            modelBuilder.Entity("WebApi_LMS_Team3.Model.LoginDb", b =>
                {
                    b.Property<int>("Emp_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Emp_Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SecurityAnswer")
                        .HasColumnType("int");

                    b.Property<string>("SecurityQuestion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Emp_Id");

                    b.ToTable("Login_T");
                });

            modelBuilder.Entity("WebApi_LMS_Team3.Model.ManagerDb", b =>
                {
                    b.Property<int>("Mng_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Mng_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Mng_Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("Mng_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Mng_Id");

                    b.ToTable("Manager_T");
                });
#pragma warning restore 612, 618
        }
    }
}
