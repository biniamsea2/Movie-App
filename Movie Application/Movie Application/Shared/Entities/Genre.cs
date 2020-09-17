using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movie_Application.Shared.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        // Allows you to customize the validation error to the user:
        //[Required(ErrorMessage ="This is an error")]
        [Required]
        public string Name { get; set; }
        //navigation property, many to many relationship
        public List<MoviesGenres> MoviesGenres { get; set; } = new List<MoviesGenres>();

    }
}
