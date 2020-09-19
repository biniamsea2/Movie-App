using Movie_Application.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Application.Client.Pages.People
{
    public interface IMoviesRepository
    {
        Task<int> CreateMovie(Movie movie);
    }
}
