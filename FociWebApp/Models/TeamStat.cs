namespace FociWebApp.Models
{
    public class TeamStat
    {
        public string TeamName { get; set; }

        public int GamesPlayed { get; set; }

        public int Wins {  get; set; }

        public int Losses {  get; set; }

        public int Ties { get; set; }

        public int Points {  get => Wins * 3 + Ties;}

        public int Goals { get; set; }

        public int GoalsConceded { get; set; }
    }
}
