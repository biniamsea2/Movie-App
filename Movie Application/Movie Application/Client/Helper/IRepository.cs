using Movie_Application.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Application.Client.Helper
{
    public interface IRepository
    {
        List<Movie> GetMovies();
    }
}
