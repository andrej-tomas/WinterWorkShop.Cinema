using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Data.Repositories
{
    public interface IProjectionRepository
    {
        List<ProjectionModel> GetAllProjections();

        ProjectionModel? GetProjectionById(int id);

        List<ProjectionModel> GetProjectionsByMovieId(int id);
    }
}
