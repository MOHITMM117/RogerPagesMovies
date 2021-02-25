using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RogerPagesMovies.Models;

namespace RogerPagesMovies.Data
{
    public class RogerPagesMoviesContext : DbContext
    {
        public RogerPagesMoviesContext (DbContextOptions<RogerPagesMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<RogerPagesMovies.Models.Movies> Movies { get; set; }
    }
}
