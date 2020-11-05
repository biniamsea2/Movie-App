using Movie_Application.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Application.Server.DTOs
{
    public class IndexPageDTO
    {
        public List<Movie> Intheaters { get; set; }
        public List<Movie> UpcomingReleases { get; set; }
    }
}
