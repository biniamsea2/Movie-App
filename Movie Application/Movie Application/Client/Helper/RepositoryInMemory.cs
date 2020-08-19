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
            new Movie() { Title = "The Wolf of Wall Street", ReleaseDate = new DateTime(2013, 12, 25), Poster="https://m.media-amazon.com/images/M/MV5BMjIxMjgxNTk0MF5BMl5BanBnXkFtZTgwNjIyOTg2MDE@._V1_SY1000_CR0,0,674,1000_AL_.jpg"},
            new Movie() { Title = "The Lion King", ReleaseDate = new DateTime(1994, 6, 24), Poster="https://m.media-amazon.com/images/M/MV5BYTYxNGMyZTYtMjE3MS00MzNjLWFjNmYtMDk3N2FmM2JiM2M1XkEyXkFqcGdeQXVyNjY5NDU4NzI@._V1_SY1000_CR0,0,673,1000_AL_.jpg" },
            new Movie() { Title = "The Godfather", ReleaseDate = new DateTime(1972, 3, 24), Poster="https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SY1000_CR0,0,704,1000_AL_.jpg" },
            new Movie() { Title = "Black Panther", ReleaseDate = new DateTime(2018, 2, 16), Poster="https://m.media-amazon.com/images/M/MV5BMTg1MTY2MjYzNV5BMl5BanBnXkFtZTgwMTc4NTMwNDI@._V1_SY1000_CR0,0,674,1000_AL_.jpg" },
            new Movie() { Title = "Catch Me if You Can", ReleaseDate = new DateTime(2002, 12, 25), Poster="https://m.media-amazon.com/images/M/MV5BMTY5MzYzNjc5NV5BMl5BanBnXkFtZTYwNTUyNTc2._V1_.jpg" },
            new Movie() { Title = "Coco", ReleaseDate = new DateTime(2017, 11, 22), Poster="https://m.media-amazon.com/images/M/MV5BYjQ5NjM0Y2YtNjZkNC00ZDhkLWJjMWItN2QyNzFkMDE3ZjAxXkEyXkFqcGdeQXVyODIxMzk5NjA@._V1_SY1000_CR0,0,699,1000_AL_.jpg"  },
            new Movie() { Title = "Us", ReleaseDate = new DateTime(2019, 2, 21), Poster="https://m.media-amazon.com/images/M/MV5BZTliNWJhM2YtNDc1MC00YTk1LWE2MGYtZmE4M2Y5ODdlNzQzXkEyXkFqcGdeQXVyMzY0MTE3NzU@._V1_SY1000_CR0,0,631,1000_AL_.jpg" },
            new Movie() { Title = "Bad Boys for Life", ReleaseDate = new DateTime(2020, 1, 17), Poster="https://m.media-amazon.com/images/M/MV5BMWU0MGYwZWQtMzcwYS00NWVhLTlkZTAtYWVjOTYwZTBhZTBiXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_SY1000_CR0,0,674,1000_AL_.jpg"  },
            new Movie() { Title = "Logan", ReleaseDate = new DateTime(2017, 3, 3), Poster="https://m.media-amazon.com/images/M/MV5BYzc5MTU4N2EtYTkyMi00NjdhLTg3NWEtMTY4OTEyMzJhZTAzXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_.jpg"  },
            new Movie() { Title = "Kong: Skull Island", ReleaseDate = new DateTime(2017, 3, 10), Poster="https://m.media-amazon.com/images/M/MV5BMTUwMzI5ODEwNF5BMl5BanBnXkFtZTgwNjAzNjI2MDI@._V1_SY1000_CR0,0,674,1000_AL_.jpg"  },
            new Movie() { Title = "Jumanji: Welcome to the Jungle", ReleaseDate = new DateTime(2017, 12, 20), Poster="https://m.media-amazon.com/images/M/MV5BOTVjMmFiMDUtOWQ4My00YzhmLWE3MzEtODM1NDFjMWEwZTRkXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_SY1000_CR0,0,674,1000_AL_.jpg"  },
            new Movie() { Title = "Queen & Slim", ReleaseDate = new DateTime(2019, 11, 27), Poster="https://m.media-amazon.com/images/M/MV5BMjIzYmJkZmEtM2RkZS00MDA4LTg4NjAtOGRkN2EwZmFmMWE4XkEyXkFqcGdeQXVyNjg2NjQwMDQ@._V1_SY1000_SX675_AL_.jpg"  },
            };
        }
    }
}
