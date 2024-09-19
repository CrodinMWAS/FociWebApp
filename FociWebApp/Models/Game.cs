namespace FociWebApp.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int Round { get; set; }
        public int HomeTeamHalfTime { get; set; }
        public int AwayTeamHalfTime { get; set; }
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set;}
        public string HomeTeam {  get; set; }
        public string AwayTeam { get; set; }

        public string WinnerTeam()
        {
            if (HomeTeamGoals > AwayTeamGoals) return HomeTeam;
            else if (HomeTeamGoals < AwayTeamGoals) return AwayTeam;
            else return "";
        }
    }
}
