using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RogerPagesMovies.Data;
using RogerPagesMovies.Models;

namespace RogerPagesMovies.Pages.Movie
{
    public class IndexModel : PageModel
    {
        private readonly RogerPagesMovies.Data.RogerPagesMoviesContext _context;

        public IndexModel(RogerPagesMovies.Data.RogerPagesMoviesContext context)
        {
            _context = context;
        }

        public IList<Movies> Movies { get;set; }

        public async Task OnGetAsync()
        {
            Movies = await _context.Movies.ToListAsync();
        }
    }
}
