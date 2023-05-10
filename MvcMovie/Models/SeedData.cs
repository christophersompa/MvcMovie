using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public class SeedData
    {
        // seeding is the process of populating a database with an inital set of data
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return; // DB has been seeded
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Harry Potter",
                        ReleaseDate = DateTime.Parse("2000-5-15"),
                        Genre = "Fantasy",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Title = "Star Wars",
                        ReleaseDate = DateTime.Parse("2004-8-23"),
                        Genre = "Sci-fi",
                        Price = 14.99M
                    },
                    new Movie 
                    {
                        Title = "SuperBad",
                        ReleaseDate = DateTime.Parse("2009-3-15"),
                        Genre = "Comdey",
                        Price = 5.99M
                    },
                    new Movie
                    {
                        Title = "John Wick",
                        ReleaseDate = DateTime.Parse("2016-10-3"),
                        Genre = "Action",
                        Price = 19.99M
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
