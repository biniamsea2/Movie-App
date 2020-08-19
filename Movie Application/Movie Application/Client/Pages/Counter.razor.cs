using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Movie_Application.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Movie_Application.Client.Shared.MainLayout;

namespace Movie_Application.Client.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        public void IncrementCount()
        {
            currentCount++;
        }



    }
}
