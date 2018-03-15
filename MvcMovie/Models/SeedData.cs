using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "The Best Two Years",
                         ReleaseDate = DateTime.Parse("2004-2-20"),
                         Genre = "Comedy",
                         Rating = "PG",
                         Price = 15.00M
                     },

                     new Movie
                     {
                         Title = "The RM",
                         ReleaseDate = DateTime.Parse("2003-1-31"),
                         Genre = "Comedy",
                         Rating = "PG",
                         Price = 15.99M
                     },

                     new Movie
                     {
                         Title = "The Other Side of Heaven",
                         ReleaseDate = DateTime.Parse("2002-4-12"),
                         Genre = "Inspirational",
                         Rating = "PG",
                         Price = 6.45M
                     },

                   new Movie
                   {
                       Title = "Meet the Mormons",
                       ReleaseDate = DateTime.Parse("2015-2-26"),
                       Genre = "Documentary",
                       Rating = "PG",
                       Price = 6.99M
                   },

                    new Movie
                    {
                        Title = "Church Ball",
                        ReleaseDate = DateTime.Parse("2006-3-17"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 6.53M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}