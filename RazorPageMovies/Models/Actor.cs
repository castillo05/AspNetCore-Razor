using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageMovies.Actors
{
    public class Actor
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Movie { get; set; }
       
    }
}
