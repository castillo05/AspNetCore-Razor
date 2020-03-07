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
    public class DetailsModelActors : PageModel
    {
        private readonly RazorPageMovies.Models.RazorPageMoviesContext _context;

        public DetailsModelActors(RazorPageMovies.Models.RazorPageMoviesContext context)
        {
            _context = context;
        }

        public Actor Actor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Actor = await _context.Actor.FirstOrDefaultAsync(m => m.ID == id);

            if (Actor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
