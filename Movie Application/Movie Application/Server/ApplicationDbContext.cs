using Microsoft.EntityFrameworkCore;
using Movie_Application.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Application.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<MovieActors>().HasKey(x => new { x.MovieId, x.PersonId });
            modelBuilder.Entity<MoviesGenres>().HasKey(x => new { x.MovieId, x.GenreId });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<MovieActors> MoviesActors { get; set; }
        public DbSet<MoviesGenres> MoviesGenres { get; set; }
    }
}
