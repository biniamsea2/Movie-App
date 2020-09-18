using Microsoft.AspNetCore.Mvc;
using Movie_Application.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Application.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenreController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public GenreController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Post(Genre genre)
        {
            context.Add(genre);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
