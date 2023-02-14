﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6_eg439.Models;

namespace Mission6_eg439.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6_eg439.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .HasColumnType("TEXT");

                    b.Property<string>("lentTo")
                        .HasColumnType("TEXT");

                    b.HasKey("MovieId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Action",
                            Director = "Your Mom",
                            Edited = true,
                            Rating = "PG-13",
                            Title = "Fast and Furious",
                            Year = "1999"
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Action",
                            Director = "Your Dad",
                            Edited = false,
                            Notes = "This is possibly the best movie ever created",
                            Rating = "PG-13",
                            Title = "Avatar",
                            Year = "2011"
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Romance/Coming of Age",
                            Director = "Your Dad",
                            Edited = false,
                            Notes = "This is another one of the greatest films every made",
                            Rating = "PG",
                            Title = "Cinderlla Story: Hillary Duff",
                            Year = "2011"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
