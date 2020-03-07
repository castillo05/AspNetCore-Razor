using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageMovies.Actors;
using RazorPageMovies.Models;

namespace RazorPageMovies
{
    public class IndexModelActors : PageModel
    {
        private readonly RazorPageMovies.Models.RazorPageMoviesContext _context;

        public IndexModelActors(RazorPageMovies.Models.RazorPageMoviesContext context)
        {
            _context = context;
        }

        public IList<Actor> Actor { get;set; }

        public async Task OnGetAsync()
        {
            Actor = await _context.Actor.ToListAsync();
        }
    }
}
