// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(StoreDb))]
    [Migration("20210630065241_StoreMigration3")]
    partial class StoreMigration3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ModelLibrary.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ModelLibrary.Inventory", b =>
                {
                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int?>("Location")
                        .HasColumnType("int");

                    b.Property<int>("NumberProducts")
                        .HasColumnType("int");

                    b.Property<int?>("Product")
                        .HasColumnType("int");

                    b.HasKey("LocationID", "ProductID");

                    b.HasIndex("Location");

                    b.HasIndex("Product");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("ModelLibrary.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("ModelLibrary.OrderDetails", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int?>("Product")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("StoreOrder")
                        .HasColumnType("int");

                    b.HasKey("OrderID", "ProductID");

                    b.HasIndex("Product");

                    b.HasIndex("StoreOrder");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ModelLibrary.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ModelLibrary.StoreOrder", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Customer")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int?>("Location")
                        .HasColumnType("int");

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderTime")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderID");

                    b.HasIndex("Customer");

                    b.HasIndex("Location");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ModelLibrary.Inventory", b =>
                {
                    b.HasOne("ModelLibrary.Location", "Locations")
                        .WithMany()
                        .HasForeignKey("Location");

                    b.HasOne("ModelLibrary.Product", "Products")
                        .WithMany()
                        .HasForeignKey("Product");

                    b.Navigation("Locations");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ModelLibrary.OrderDetails", b =>
                {
                    b.HasOne("ModelLibrary.Product", "Products")
                        .WithMany()
                        .HasForeignKey("Product");

                    b.HasOne("ModelLibrary.StoreOrder", "Orders")
                        .WithMany()
                        .HasForeignKey("StoreOrder");

                    b.Navigation("Orders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ModelLibrary.StoreOrder", b =>
                {
                    b.HasOne("ModelLibrary.Customer", "Customers")
                        .WithMany()
                        .HasForeignKey("Customer");

                    b.HasOne("ModelLibrary.Location", "Locations")
                        .WithMany()
                        .HasForeignKey("Location");

                    b.Navigation("Customers");

                    b.Navigation("Locations");
                });
#pragma warning restore 612, 618
        }
    }
}
