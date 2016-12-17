using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieCatalog
{
    class MovieList
    {
        public List<Movie> AllMovies = new List<Movie>();

        

        public void AddMovie()
        {
            Movie noviFilm = new Movie();
            noviFilm.MovieName = "Avatar";
            noviFilm.genre = Movie.Genre.Action;
            noviFilm.Director = "James Cameroon";
            noviFilm.Date = new DateTime(2011, 12, 2);
            


            AllMovies.Add(noviFilm);


            
        }


       

        
    }
}
