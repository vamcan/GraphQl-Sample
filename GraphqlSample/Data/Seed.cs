using GraphqlSample.Models;

namespace GraphqlSample.Data
{
    public class Seed
    {
        public static List<Movie> SeedData()
        {
            var actors = new List<Actor>
            {
                new Actor
                {
                    FirstName = "Bob",
                    LastName = "Kante"
                },
                new Actor
                {
                    FirstName = "Mary",
                    LastName = "Poppins"
                }
            };

            var movies = new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Title = "The Rise of the GraphQL Warrior",
                    Actors = actors
                },
                new Movie
                {
                    Id = 2,
                    Title = "The Rise of the GraphQL Warrior Part 2",
                    Actors = actors
                }
            };
            return movies;
        }
    }
}
