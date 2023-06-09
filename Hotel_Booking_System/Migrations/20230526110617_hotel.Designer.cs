﻿// <auto-generated />
using System;
using Hotel_Booking_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotel_Booking_System.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20230526110617_hotel")]
    partial class hotel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hotel_Booking_System.Models.Booking", b =>
                {
                    b.Property<int>("Book_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Book_Id"));

                    b.Property<string>("Booking_Person_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Customer_Id")
                        .HasColumnType("int");

                    b.Property<int>("Days")
                        .HasColumnType("int");

                    b.Property<int?>("Hotel_Id")
                        .HasColumnType("int");

                    b.Property<double>("Phone_Number")
                        .HasColumnType("float");

                    b.Property<int?>("Room_Id")
                        .HasColumnType("int");

                    b.HasKey("Book_Id");

                    b.HasIndex("Customer_Id");

                    b.HasIndex("Hotel_Id");

                    b.HasIndex("Room_Id");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Hotel_Booking_System.Models.Customer", b =>
                {
                    b.Property<int>("Customer_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Customer_Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Customer_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Hotel_Id")
                        .HasColumnType("int");

                    b.Property<double>("Phone_Number")
                        .HasColumnType("float");

                    b.HasKey("Customer_Id");

                    b.HasIndex("Hotel_Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Hotel_Booking_System.Models.Employee", b =>
                {
                    b.Property<int>("Employee_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Employee_Id"));

                    b.Property<string>("Employee_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Hotel_Id")
                        .HasColumnType("int");

                    b.HasKey("Employee_Id");

                    b.HasIndex("Hotel_Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Hotel_Booking_System.Models.Hotel", b =>
                {
                    b.Property<int>("Hotel_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Hotel_Id"));

                    b.Property<string>("Amenities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hotel_Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hotel_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.HasKey("Hotel_Id");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("Hotel_Booking_System.Models.Room", b =>
                {
                    b.Property<int>("Room_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Room_Id"));

                    b.Property<int?>("Hotel_Id")
                        .HasColumnType("int");

                    b.Property<string>("Room_Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Room_Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Room_Id");

                    b.HasIndex("Hotel_Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Hotel_Booking_System.Models.User", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_Id"));

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Hotel_Booking_System.Models.Booking", b =>
                {
                    b.HasOne("Hotel_Booking_System.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customer_Id");

                    b.HasOne("Hotel_Booking_System.Models.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("Hotel_Id");

                    b.HasOne("Hotel_Booking_System.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("Room_Id");

                    b.Navigation("Customer");

                    b.Navigation("Hotel");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Hotel_Booking_System.Models.Customer", b =>
                {
                    b.HasOne("Hotel_Booking_System.Models.Hotel", "Hotel")
                        .WithMany("Customers")
                        .HasForeignKey("Hotel_Id");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Hotel_Booking_System.Models.Employee", b =>
                {
                    b.HasOne("Hotel_Booking_System.Models.Hotel", "Hotel")
                        .WithMany("Employees")
                        .HasForeignKey("Hotel_Id");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Hotel_Booking_System.Models.Room", b =>
                {
                    b.HasOne("Hotel_Booking_System.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("Hotel_Id");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Hotel_Booking_System.Models.Hotel", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Employees");

                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
