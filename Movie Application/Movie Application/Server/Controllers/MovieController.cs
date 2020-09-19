using Microsoft.AspNetCore.Mvc;
using Movie_Application.Server.Helpers;
using Movie_Application.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Application.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFileStorageService fileStorageService;
        public MovieController(ApplicationDbContext context, IFileStorageService fileStorageService)
        {
            this.context = context;
            this.fileStorageService = fileStorageService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Movie movie)
        {
            if (!string.IsNullOrWhiteSpace(movie.Poster))
            {
                var poster = Convert.FromBase64String(movie.Poster);
                movie.Poster = await fileStorageService.SaveFile(poster, "jpg", "movies");
            }
            context.Add(movie);
            await context.SaveChangesAsync();
            return movie.Id;
        }
    }
}

