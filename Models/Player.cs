namespace GameChampion.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? EmailAdress { get; set; }
        public string? Password { get; set; }
        public ICollection<PlayerTournament>? Players { get; set; }
            

    }
}
