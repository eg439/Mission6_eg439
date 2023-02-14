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


        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Title = "Fast and Furious",
                    Category = "Action",
                    Year = "1999",
                    Director = "Your Mom",
                    Rating = "PG-13",
                    Edited = true
                },
                new Movie
                {
                    MovieId = 2,
                    Title = "Avatar",
                    Category = "Action",
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
                    Category = "Romance/Coming of Age",
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
