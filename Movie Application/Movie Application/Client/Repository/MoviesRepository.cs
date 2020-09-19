using Movie_Application.Client.Helper;
using Movie_Application.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Application.Client.Pages.People
{
    public class MoviesRepository : IMoviesRepository
    {

        private readonly IHttpService httpService;
        private string url = "api/movies";

        public MoviesRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<int> CreateMovie(Movie movie)
        {
            var response = await httpService.Post<Movie,int>(url, movie);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
    }
}
