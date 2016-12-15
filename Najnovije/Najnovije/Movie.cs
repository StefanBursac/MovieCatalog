using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Najnovije
{
    public class Movie
    {
        List<string> lista = new List<string>();

        public string name;

        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        public string AddMovies(string movie)
        {
            lista.Add(movie);

            return movie;
        }


    }
}
