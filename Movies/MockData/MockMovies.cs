using Movies.Models;

namespace Movies.MockData
{
    public class MockMovies
    {
        public List<MovieModel> movieList = new List<MovieModel>()
        {
            new MovieModel() { Id = 1, Title = "Harry Potter", Year = 1999, RunningTimeInMins = 151, StudioId = 1 },
            new MovieModel() { Id = 2, Title = "Perry Hotter", Year = 2001, RunningTimeInMins = 131, StudioId = 2},
            new MovieModel() { Id = 3, Title = "Hot Perry hot", Year = 2020, RunningTimeInMins = 181, StudioId = 3},
        };
    }
}
