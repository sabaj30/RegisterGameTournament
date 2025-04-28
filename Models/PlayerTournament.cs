namespace GameChampion.Models
{
    public class PlayerTournament
    {
        public int Id { get; set; }
        public Player? Player { get; set; }
        public Tournament? Tournament { get; set; }
    }
}
