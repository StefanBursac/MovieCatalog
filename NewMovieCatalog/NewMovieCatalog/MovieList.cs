using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieCatalog
{
    class MovieList
    {
        public ObservableCollection<Movie> AllMovies = new ObservableCollection<Movie>();

        

        public void AddMovie()
        {
            Movie noviFilm = new Movie();
            noviFilm.MovieName = "Avatar";
            noviFilm.genre = Movie.Genre.Action;
            noviFilm.Director = "James Cameroon";
            noviFilm.Date = new DateTime(2011, 12, 2);

            Movie noviFilm2 = new Movie();
            noviFilm2.MovieName = "Kamerom";
            noviFilm2.genre = Movie.Genre.Action;
            noviFilm2.Director = "James Avatur";
            noviFilm2.Date = new DateTime(2011, 12, 2);

            AllMovies.Add(noviFilm);
            AllMovies.Add(noviFilm2);
        }


       

        
    }
}
