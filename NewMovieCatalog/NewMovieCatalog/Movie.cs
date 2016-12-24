using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieCatalog
{
    class Movie
    {

        public string MovieName { get; set;}

        public enum Genre {Action,Fantasy,Comedy,SciFi}
        public Genre genre { get; set; } 

        public string Director { get; set; }

        public DateTime Date { get; set; }



        
      

    }
}

