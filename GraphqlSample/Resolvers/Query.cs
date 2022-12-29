using GraphqlSample.Data;
using GraphqlSample.Models;

namespace GraphqlSample.Resolvers
{
    public class Query
    {
        public List<Movie> GetMovies() =>
            Seed.SeedData();

        public Movie GetMovieById(int id) =>
            Seed.SeedData().FirstOrDefault(x => x.Id == id);
    }
}
