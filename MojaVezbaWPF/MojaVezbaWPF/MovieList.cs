using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaVezbaWPF
{
    public class MovieList
    {
       ObservableCollection <Movie> ListaFilmova  = new ObservableCollection<Movie>();

        public void AddMovies()
        {
            ListaFilmova.Add(new Movie() { MovieName = "Ja", MovieDirector = "Ja" });
            ListaFilmova.Add(new Movie() { MovieName = "Mi", MovieDirector = "Oni" });
        }

       }
}
