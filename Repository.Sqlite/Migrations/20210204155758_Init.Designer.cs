﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Sqlite;

namespace Repository.Sqlite.Migrations
{
    [DbContext(typeof(SalaryCalculationContext))]
    [Migration("20210204155758_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11");

            modelBuilder.Entity("Repository.Sqlite.Entities.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("BaseSalary")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ChiefId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("WorkingSince")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChiefId");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("Repository.Sqlite.Entities.Staff", b =>
                {
                    b.HasOne("Repository.Sqlite.Entities.Staff", "Chief")
                        .WithMany()
                        .HasForeignKey("ChiefId");
                });
#pragma warning restore 612, 618
        }
    }
}
