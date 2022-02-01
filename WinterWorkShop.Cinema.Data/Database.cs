using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Data
{
    public class Database
    {
        public List<MovieModel> GetAllMoviesResponses = new List<MovieModel>
        {
            new MovieModel { Id = 1, Name = "The Schindler's List" },
            new MovieModel { Id = 2, Name = "The Ten Commandments" }
        };

        public List<ProjectionModel> GetAllProjections = new List<ProjectionModel>
        {
            new ProjectionModel { Id = 1, CinemaName = "Cineplex", ProjectionDate = DateTime.Now, MovieId  = 1},
            new ProjectionModel { Id = 2, CinemaName = "CinemaPlus", ProjectionDate = DateTime.Now, MovieId  = 1},
            new ProjectionModel { Id = 3, CinemaName = "Cineplex", ProjectionDate = DateTime.Now, MovieName = 2}
        };
    }
}
