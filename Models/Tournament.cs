namespace GameChampion.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public ICollection<Game>? Games { get; set; }
    }
}
