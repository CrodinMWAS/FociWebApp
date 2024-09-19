using FociWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FociWebApp.Pages
{
    public class StatsModel : PageModel
    {
        private readonly SoccerDBContext _context;

        
        public StatsModel(SoccerDBContext context)
        {
            _context = context;
        }

        public List<Game> games;
        public List<TeamStat> stats = new List<TeamStat>();

        public void OnGet()
        {
            games = _context.Games.ToList();
            
            foreach (var teamName in games.Select(x => x.HomeTeam).Distinct())
            {
                TeamStat newTeam = new TeamStat();
                newTeam.TeamName = teamName;
                stats.Add(newTeam);
            }

            foreach (var team in stats) 
            {
                team.Wins = games.Count(x => x.WinnerTeam() == team.TeamName);
                team.Losses = games.Count(x => x.WinnerTeam() == x.AwayTeam);
                team.Ties = games.Count(x => x.WinnerTeam() == "");
                team.GamesPlayed = team.Wins + team.Losses + team.Ties;
                
                //...

                //Rendezés
            }
        }
    }
}
