using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Data
{
    public class Database
    {
        public List<MovieModel> GetAllMoviesResponses = new List<MovieModel>
        {
            new MovieModel { Id = 1, Name = "Spiderman 1" },
            new MovieModel { Id = 2, Name = "Spiderman 2"}
        };

        public List<ProjectionModel> GetAllProjections = new List<ProjectionModel>
        {
            new ProjectionModel { Id = 3, CinemaName = "Cineplex", ProjectionDate = DateTime.Now, MovieName  = "Spiderman 1"},
            new ProjectionModel { Id = 4, CinemaName = "Cineplex", ProjectionDate = DateTime.Now, MovieName = "Spiderman 2"}
        };
    }
}
