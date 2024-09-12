using Microsoft.EntityFrameworkCore;

namespace FociWebApp.Models
{
    //ADATBAZIS KAPCSOLAT
    public class SoccerDBContext : DbContext
    {
        //ADATBAZIS KAPCSOLAT
        public SoccerDBContext(DbContextOptions<SoccerDBContext> options) : base(options) 
        { 
            
        }

        //Rekord
        public DbSet<Game> Games { get; set; }
    }
}
