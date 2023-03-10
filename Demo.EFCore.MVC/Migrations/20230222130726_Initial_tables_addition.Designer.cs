// <auto-generated />
using System;
using Demo.EFCore.MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Demo.EFCore.MVC.Migrations
{
    [DbContext(typeof(ADVFoodDbContext))]
    [Migration("20230222130726_Initial_tables_addition")]
    partial class Initialtablesaddition
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Demo.EFCore.MVC.Models.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Hyderabad",
                            Contact = "12345",
                            Email = "ms@bbc.com",
                            Name = "John"
                        },
                        new
                        {
                            Id = 2,
                            City = "Punjab",
                            Contact = "45687",
                            Email = "ms2@bbc.com",
                            Name = "Ron"
                        },
                        new
                        {
                            Id = 3,
                            City = "Nagpur",
                            Contact = "04669",
                            Email = "ms3@bbc.com",
                            Name = "Tony"
                        });
                });

            modelBuilder.Entity("Demo.EFCore.MVC.Models.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            CreatedDate = new DateTime(2023, 2, 22, 18, 37, 26, 21, DateTimeKind.Local).AddTicks(456),
                            CustomerId = 1,
                            Quantity = 1,
                            TotalAmount = 0.0
                        },
                        new
                        {
                            Id = 102,
                            CreatedDate = new DateTime(2023, 2, 22, 18, 37, 26, 21, DateTimeKind.Local).AddTicks(470),
                            CustomerId = 1,
                            Quantity = 1,
                            TotalAmount = 0.0
                        },
                        new
                        {
                            Id = 103,
                            CreatedDate = new DateTime(2023, 2, 22, 18, 37, 26, 21, DateTimeKind.Local).AddTicks(472),
                            CustomerId = 2,
                            Quantity = 1,
                            TotalAmount = 0.0
                        });
                });

            modelBuilder.Entity("Demo.EFCore.MVC.Models.Orders", b =>
                {
                    b.HasOne("Demo.EFCore.MVC.Models.Customers", "Customers")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Demo.EFCore.MVC.Models.Customers", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
