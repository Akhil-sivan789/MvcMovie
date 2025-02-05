using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class newMovie
{
    public static void InitializenewMovie(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
           
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Into the wild",
                    ReleaseDate = DateTime.Parse("2007-3-12"),
                    Genre = "Survival",
                    Rating = "R",
                    Price = 6.99M
                }
                
            );
            context.SaveChanges();
        }
    }
}
