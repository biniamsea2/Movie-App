using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Application.Client
{
    /// <summary>
    /// through dependency injection we are able to request instances of these objects
    /// </summary>
    public class SingletonService
    {
        public int Value { get; set; }
    }
    public class TransientService
    {
        public int Value { get; set; }
    }
}
