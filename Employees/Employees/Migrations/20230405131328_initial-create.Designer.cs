﻿// <auto-generated />
using System;
using Employees.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Employees.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20230405131328_initial-create")]
    partial class initialcreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Employees.Models.Employee", b =>
                {
                    b.Property<Guid>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EmpFname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EmpLname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uuid");

                    b.HasKey("EmpId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Employees.Models.EmployeePosition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateOfJoining")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EmpPosition")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Salary")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("EmployeePositions");
                });
#pragma warning restore 612, 618
        }
    }
}
