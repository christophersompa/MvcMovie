using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    // MvcMovieContext object handles the task of connecting to the database and mapping Movie objects
    // to database records.
    public class MvcMovieContext : DbContext
        // DbContext represents a session of a database that can be used to query and save entites.
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
