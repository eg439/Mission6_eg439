using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mission6_eg439.Models
{
    public class MovieContext : DbContext
    {
        //constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            //Leave Blank for now
        }

        public DbSet<Movie> responses { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Romance" },
                new Category { CategoryId = 4, CategoryName = "SciFi" },
                new Category { CategoryId = 5, CategoryName = "Horror" },
                new Category { CategoryId = 6, CategoryName = "Thriller" },
                new Category { CategoryId = 7, CategoryName = "Fantasy" },
                new Category { CategoryId = 8, CategoryName = "Mystery" },
                new Category { CategoryId = 9, CategoryName = "Musical" }
                );




            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Title = "Fast and Furious",
                    CategoryId = 1,
                    Year = "1999",
                    Director = "Your Mom",
                    Rating = "PG-13",
                    Edited = true
                },
                new Movie
                {
                    MovieId = 2,
                    Title = "Avatar",
                    CategoryId = 1,
                    Year = "2011",
                    Director = "Your Dad",
                    Rating = "PG-13",
                    Edited = false,
                    Notes = "This is possibly the best movie ever created"
                },
                new Movie
                {
                    MovieId = 3,
                    Title = "Cinderlla Story: Hillary Duff",
                    CategoryId = 3 ,
                    Year = "2011",
                    Director = "Your Dad",
                    Rating = "PG",
                    Edited = false,
                    Notes = "This is another one of the greatest films every made"
                }
                );
        }
    }
}
