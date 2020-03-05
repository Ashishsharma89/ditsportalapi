﻿// <auto-generated />
using System;
using DitsPortal.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DitsPortal.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20191221072054_GlobalCodescate")]
    partial class GlobalCodescate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DitsPortal.DataAccess.DBEntities.Base.GlobalCodeCategories", b =>
                {
                    b.Property<int>("GlobalCodeCategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(1000)");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("Datetime");

                    b.HasKey("GlobalCodeCategoryId");

                    b.ToTable("GlobalCodeCategories");
                });

            modelBuilder.Entity("DitsPortal.DataAccess.DBEntities.GlobalCodes", b =>
                {
                    b.Property<int>("GlobalCodeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodeName")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(1000)");

                    b.Property<int>("GlobalCodeCategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("Datetime");

                    b.HasKey("GlobalCodeId");

                    b.ToTable("GlobalCodes");
                });

            modelBuilder.Entity("DitsPortal.DataAccess.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AlternateNumber");

                    b.Property<int?>("BloodGroup");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("Datetime");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("Datetime");

                    b.Property<DateTime?>("DateOfJoining");

                    b.Property<DateTime?>("DateOfLeaving");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("Datetime");

                    b.Property<int?>("Designation")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastLoggedIn");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("MediaId");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("OfficialEmail");

                    b.Property<string>("PAN");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Phone");

                    b.Property<string>("ResetToken");

                    b.Property<DateTime>("ResetTokenExpired");

                    b.Property<string>("Skype");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
