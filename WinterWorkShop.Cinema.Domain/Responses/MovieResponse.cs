namespace WinterWorkShop.Cinema.Domain.Responses
{
    public class MovieResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DirectorName { get; set; }
        public double Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<ProjectionResponse> Projections { get; private set; } = new List<ProjectionResponse>();
    }
}