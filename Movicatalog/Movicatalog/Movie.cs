using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Movicatalog
{
    public class Movie : INotifyPropertyChanged
    {
        private string name;
        private Genre _genre;
        private string director;
        private DateTime date;

        public string Name
        {
            get { return name; }

            set { name = value; }

        }

        public enum Genre
        {
            Action,
            Fantasy,
            Comedy,
            SciFi,
            Drama
        }

        public Genre zanr
        {
            get { return _genre; }

            set
            { _genre = value;
                RaisePropertyChanged();
            }
        }

        public string Director
        {
            get { return director; }

            set { director = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public static ObservableCollection<Movie> GetMovies()
        {
            var movies = new ObservableCollection<Movie>();

            movies.Add(new Movie() { Name = "Dark Knight",  zanr = Genre.Action, Director = "Cristopher Nolan", Date = new DateTime(2007, 1, 1) });
            movies.Add(new Movie() { Name = "Avatar", zanr = Genre.Fantasy, Director = "James Cameroon", Date = new DateTime(2011, 12, 12) });
            movies.Add(new Movie() { Name = "The Matrix", zanr = Genre.SciFi, Director = "Wachowski Brother and Sister", Date = new DateTime(2007, 1, 1) });
            movies.Add(new Movie() { Name = "The Avengers", zanr = Genre.Action, Director = "Marvel Studios", Date = new DateTime(2011, 12, 12) });
            movies.Add(new Movie() { Name = "Star Wars - The Force Awakens", zanr = Genre.SciFi, Director = "Disney", Date = new DateTime(2015 / 12 / 6) });
            
            return movies;
        }



       

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(
            [CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
            


    }
}


