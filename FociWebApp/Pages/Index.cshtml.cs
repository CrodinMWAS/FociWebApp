using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FociWebApp.Models;

namespace FociWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly FociWebApp.Models.SoccerDBContext _context;

        public IndexModel(FociWebApp.Models.SoccerDBContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Game = await _context.Games.ToListAsync();
        }
    }
}
