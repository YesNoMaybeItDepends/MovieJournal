﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieJournal.Server.Data;

#nullable disable

namespace MovieJournal.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220829174918_NoStatus")]
    partial class NoStatus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("MovieJournal.Shared.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Stars")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "Crime",
                            Image = "",
                            Review = "Yep",
                            Stars = 55,
                            Title = "Street Kings",
                            Year = 2008
                        },
                        new
                        {
                            Id = 2,
                            Genre = "Animation",
                            Image = "",
                            Review = "Yep",
                            Stars = 96,
                            Title = "Spirited Away",
                            Year = 2001
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
