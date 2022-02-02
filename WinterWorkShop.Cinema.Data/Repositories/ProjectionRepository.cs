using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Data.Repositories
{
    public class ProjectionRepository : IProjectionRepository
    {
        public Database Database = new Database();


        public List<ProjectionModel> GetAllProjections()
        {
            return Database.GetAllProjections;
        }

        public ProjectionModel? GetProjectionById(int id)
        {
            var projection = Database.GetAllProjections.FirstOrDefault(x => x.Id == id);

            return projection;
        }

        public List<ProjectionModel>? GetProjectionsByMovieId(int id)
        {
            var movie = Database.GetAllMoviesResponses.Any(m => m.Id == id);

            return movie ?
                Database.GetAllProjections.Where(p => p.MovieId == id).ToList()
                : null;
        }

    }
}
