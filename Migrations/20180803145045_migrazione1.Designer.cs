﻿// <auto-generated />
using FreeezeDotNet.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FreeezeDotNet.Migrations
{
    [DbContext(typeof(FreezerContext))]
    [Migration("20180803145045_migrazione1")]
    partial class migrazione1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FreeezeDotNet.Model.Drawer", b =>
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

            modelBuilder.Entity("FreeezeDotNet.Model.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrawerId");

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.Property<int>("Portion");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("DrawerId");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("FreeezeDotNet.Model.Freezer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Freezers");
                });

            modelBuilder.Entity("FreeezeDotNet.Model.Drawer", b =>
                {
                    b.HasOne("FreeezeDotNet.Model.Freezer", "Freezer")
                        .WithMany("Drawers")
                        .HasForeignKey("FreezerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FreeezeDotNet.Model.Food", b =>
                {
                    b.HasOne("FreeezeDotNet.Model.Drawer", "Drawer")
                        .WithMany("DrawerFood")
                        .HasForeignKey("DrawerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}