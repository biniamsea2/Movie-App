using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Application.Shared.Entities
{
    public class MoviesGenres
    {
        //because its a many to many relationship with genres we have the moviesGenres
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        public Movie Movie { get; set; }
        public Genre Genre { get; set; }
    }
}
