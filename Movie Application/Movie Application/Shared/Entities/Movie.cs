using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movie_Application.Shared.Entities
{
    public class Movie
    {
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
    }
}
