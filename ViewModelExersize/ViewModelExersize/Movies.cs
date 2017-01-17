using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelExersize
{
    public class Movies
    {

        public string MovieName { get; set; }
        public string MovieDirector { get; set; }
        public DateTime ReleaseDate { get; set; } 

        public ObservableCollection<Movies> MovieList = new ObservableCollection<Movies>(); 


        
        public void AddMovie()
        {
            
            MovieList.Add(new Movies() { MovieName = "Dark Knight", MovieDirector = "Christopher Nolan", ReleaseDate = new DateTime(2012,6,12)});
            MovieList.Add(new Movies() { MovieName = "Avengers", MovieDirector = "Disney", ReleaseDate = new DateTime(2014, 6, 12) });
            
        }
    }
}
