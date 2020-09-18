using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Application.Client.Repository
{
    public interface IGenreRepository
    {
        Task CreateGenre(GenreRepository genre);
    }
}
