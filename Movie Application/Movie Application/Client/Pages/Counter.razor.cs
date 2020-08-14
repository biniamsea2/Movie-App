using Microsoft.AspNetCore.Components;
using Movie_Application.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Application.Client.Pages
{
    public partial class Counter
    {
        //use the attribute inject and make it a property in order to use it here
        [Inject] SingletonService singleton { get; set; }
        [Inject] TransientService transient { get; set; }
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            transient.Value = currentCount;
            singleton.Value = currentCount;
        }


        private List<Movie> movies;
        // OnInitialized runs when our razor file loads
        protected override void OnInitialized()
        {
            //await Task.Delay(3500);
            movies = new List<Movie>()
{
            new Movie () {Title = "Logan", ReleaseDate = new DateTime(2017, 3, 3)},
            new Movie () {Title = "Kong: Skull Island", ReleaseDate = new DateTime(2017, 3, 10)},
            new Movie () {Title = "Jumanji: Welcome to the Jungle", ReleaseDate = new DateTime(2017, 12, 20)},
        };
        }
    }
}
