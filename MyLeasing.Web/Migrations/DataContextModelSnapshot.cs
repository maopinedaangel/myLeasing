﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyLeasing.Web.Data;

#nullable disable

namespace MyLeasing.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyLeasing.Web.Data.Entities.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("LesseeId")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("PropertyId")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LesseeId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("PropertyId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("MyLeasing.Web.Data.Entities.Lessee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FixedPhone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Lessees");
                });

            modelBuilder.Entity("MyLeasing.Web.Data.Entities.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FixedPhone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("MyLeasing.Web.Data.Entities.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("HasParkingLot")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PropertyTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rooms")
                        .HasColumnType("int");

                    b.Property<int>("SquareMeters")
                        .HasColumnType("int");

                    b.Property<int>("Stratum")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("PropertyTypeId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("MyLeasing.Web.Data.Entities.PropertyImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("PropertyImages");
                });

            modelBuilder.Entity("MyLeasing.Web.Data.Entities.PropertyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("PropertyTypes");
                });

            modelBuilder.Entity("MyLeasing.Web.Data.Entities.Contract", b =>
                {
                    b.HasOne("MyLeasing.Web.Data.Entities.Lessee", "Lessee")
                        .WithMany("Contracts")
                        .HasForeignKey("LesseeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyLeasing.Web.Data.Entities.Owner", "Owner")
                        .WithMany("Contracts")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyLeasing.Web.Data.Entities.Property", "Property")
                        .WithMany("Contracts")
                        .HasForeignKey("PropertyId");

                    b.Navigation("Lessee");

                    b.Navigation("Owner");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("MyLeasing.Web.Data.Entities.Property", b =>
                {
                    b.HasOne("MyLeasing.Web.Data.Entities.Owner", "Owner")
                        .WithMany("Properties")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyLeasing.Web.Data.Entities.PropertyType", "PropertyType")
                        .WithMany("Properties")
                        .HasForeignKey("PropertyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("PropertyType");
                });

            modelBuilder.Entity("MyLeasing.Web.Data.Entities.PropertyImage", b =>
                {
                    b.HasOne("MyLeasing.Web.Data.Entities.Property", "Property")
                        .WithMany("PropertyImages")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("MyLeasing.Web.Data.Entities.Lessee", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("MyLeasing.Web.Data.Entities.Owner", b =>
                {
                    b.Navigation("Contracts");

                    b.Navigation("Properties");
                });

            modelBuilder.Entity("MyLeasing.Web.Data.Entities.Property", b =>
                {
                    b.Navigation("Contracts");

                    b.Navigation("PropertyImages");
                });

            modelBuilder.Entity("MyLeasing.Web.Data.Entities.PropertyType", b =>
                {
                    b.Navigation("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}
