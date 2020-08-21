using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Application.Shared.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public string Picture { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
