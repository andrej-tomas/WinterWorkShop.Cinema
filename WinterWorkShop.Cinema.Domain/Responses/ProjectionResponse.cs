namespace WinterWorkShop.Cinema.Domain.Responses
{
    public class ProjectionResponse
    {
      
        public int Id { get; set; }
        public DateTime ProjectionDate { get; set; }
        public string CinemaName { get; set; }
        public int MovieId { get; set; }
    }
}
