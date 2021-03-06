﻿// <auto-generated />
using Inventory.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Inventory.Migrations
{
    [DbContext(typeof(FreezerContext))]
    [Migration("20180803150246_migrazione2")]
    partial class migrazione2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Inventory.Model.Drawer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FreezerId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("FreezerId");

                    b.ToTable("Drawer");
                });

            modelBuilder.Entity("Inventory.Model.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrawerId");

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.Property<int>("Portion");

                    b.Property<int>("PortionId");

                    b.Property<int>("Type");

                    b.Property<int>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("DrawerId");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("Inventory.Model.Freezer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Freezers");
                });

            modelBuilder.Entity("Inventory.Model.Drawer", b =>
                {
                    b.HasOne("Inventory.Model.Freezer", "Freezer")
                        .WithMany("Drawers")
                        .HasForeignKey("FreezerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Inventory.Model.Food", b =>
                {
                    b.HasOne("Inventory.Model.Drawer", "Drawer")
                        .WithMany("DrawerFood")
                        .HasForeignKey("DrawerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
