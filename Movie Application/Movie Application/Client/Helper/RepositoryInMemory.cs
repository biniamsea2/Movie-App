using Movie_Application.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Application.Client.Helper
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
            new Movie() { Title = "The Wolf of Wall Street", ReleaseDate = new DateTime(2013, 12, 25) },
            new Movie() { Title = "The Lion King", ReleaseDate = new DateTime(1994, 6, 24) },
            new Movie() { Title = "The Godfather", ReleaseDate = new DateTime(1972, 3, 24) },
            new Movie() { Title = "Catch Me if You Can", ReleaseDate = new DateTime(2002, 12, 25) },
            new Movie() { Title = "Coco", ReleaseDate = new DateTime(2017, 11, 22) },
            new Movie() { Title = "Us", ReleaseDate = new DateTime(2019, 2, 21) },
            new Movie() { Title = "Bad Boys for Life", ReleaseDate = new DateTime(2020, 1, 17) },
            new Movie() { Title = "Logan", ReleaseDate = new DateTime(2017, 3, 3) },
            new Movie() { Title = "Kong: Skull Island", ReleaseDate = new DateTime(2017, 3, 10) },
            new Movie() { Title = "Jumanji: Welcome to the Jungle", ReleaseDate = new DateTime(2017, 12, 20) },
            };
        }
    }
}
