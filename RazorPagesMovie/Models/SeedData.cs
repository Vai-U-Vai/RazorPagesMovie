using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesMovieContext>>()))
        {
            if (context == null || context.Movie == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }

            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "R"
                },

                new Movie
                {
                    Title = "Ghostbusters",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "A"
                },

                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "Z"
                },

                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "R"
                },

                // Добавляем дополнительные фильмы для достижения трех страниц
                new Movie
                {
                    Title = "Casablanca",
                    ReleaseDate = DateTime.Parse("1942-11-26"),
                    Genre = "Romantic Drama",
                    Price = 10.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "The Godfather",
                    ReleaseDate = DateTime.Parse("1972-3-24"),
                    Genre = "Crime",
                    Price = 14.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Pulp Fiction",
                    ReleaseDate = DateTime.Parse("1994-10-14"),
                    Genre = "Crime",
                    Price = 12.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "The Shawshank Redemption",
                    ReleaseDate = DateTime.Parse("1994-9-23"),
                    Genre = "Drama",
                    Price = 9.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Schindler's List",
                    ReleaseDate = DateTime.Parse("1993-12-15"),
                    Genre = "Historical Drama",
                    Price = 11.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "The Dark Knight",
                    ReleaseDate = DateTime.Parse("2008-7-18"),
                    Genre = "Action",
                    Price = 13.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Fight Club",
                    ReleaseDate = DateTime.Parse("1999-10-15"),
                    Genre = "Drama",
                    Price = 10.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Forrest Gump",
                    ReleaseDate = DateTime.Parse("1994-7-6"),
                    Genre = "Drama",
                    Price = 8.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Inception",
                    ReleaseDate = DateTime.Parse("2010-7-16"),
                    Genre = "Sci-Fi",
                    Price = 12.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "The Matrix",
                    ReleaseDate = DateTime.Parse("1999-3-31"),
                    Genre = "Sci-Fi",
                    Price = 9.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "The Lord of the Rings: The Return of the King",
                    ReleaseDate = DateTime.Parse("2003-12-17"),
                    Genre = "Fantasy",
                    Price = 14.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Star Wars: Episode IV - A New Hope",
                    ReleaseDate = DateTime.Parse("1977-5-25"),
                    Genre = "Sci-Fi",
                    Price = 11.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Jurassic Park",
                    ReleaseDate = DateTime.Parse("1993-6-11"),
                    Genre = "Adventure",
                    Price = 9.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "The Silence of the Lambs",
                    ReleaseDate = DateTime.Parse("1991-2-14"),
                    Genre = "Thriller",
                    Price = 12.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "The Lion King",
                    ReleaseDate = DateTime.Parse("1994-6-15"),
                    Genre = "Animation",
                    Price = 8.99M,
                    Rating = "G"
                },
                new Movie
                {
                    Title = "Gladiator",
                    ReleaseDate = DateTime.Parse("2000-5-5"),
                    Genre = "Action",
                    Price = 10.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "The Avengers",
                    ReleaseDate = DateTime.Parse("2012-5-4"),
                    Genre = "Action",
                    Price = 14.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Titanic",
                    ReleaseDate = DateTime.Parse("1997-12-19"),
                    Genre = "Romance",
                    Price = 10.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Avatar",
                    ReleaseDate = DateTime.Parse("2009-12-18"),
                    Genre = "Sci-Fi",
                    Price = 13.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "The Social Network",
                    ReleaseDate = DateTime.Parse("2010-10-1"),
                    Genre = "Biography",
                    Price = 11.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "The Dark Knight Rises",
                    ReleaseDate = DateTime.Parse("2012-7-20"),
                    Genre = "Action",
                    Price = 12.99M,
                    Rating = "PG-13"
                }
            );
            context.SaveChanges();
        }
    }
}
