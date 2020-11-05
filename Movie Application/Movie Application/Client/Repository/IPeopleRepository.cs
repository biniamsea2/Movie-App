using Movie_Application.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Application.Client.Repository
{
    public interface IPeopleRepository
    {
        Task CreatePerson(Person genre);
        Task<List<Person>> GetPeople();
        Task<List<Person>> GetPeopleByName(string name);
    }
}
