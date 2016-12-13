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
        private string genre;
        private string director;
        private DateTime date;

        public string Name
        {
            get { return name; }

            set { name = value; }

        }

        public string Genre
        {
            get { return genre; }

            set { genre = value; }
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

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnProperyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        public static ObservableCollection<Movie> GetMovies()
        {
            var movies = new ObservableCollection<Movie>();

            movies.Add(new Movie() { Name = "Dark Knight", Genre = "Action", Director = "Christopher Nolan ", Date = new DateTime(2007, 1, 6) });
            movies.Add(new Movie() { Name = "Avatar", Genre = "Fantasy", Director = "James Cameroon", Date = new DateTime(2011, 12, 6) });
            movies.Add(new Movie() { Name = "The Lord of the Rings: The Return of the King", Genre = "Fantasy", Director = "Peter Jackson", Date = new DateTime(2003, 12, 17) });
            movies.Add(new Movie() { Name = "The Good, the Bad and the Ugly", Genre = "Western", Director = "Sergio Leone", Date = new DateTime(1967, 12, 19) });
            movies.Add(new Movie() { Name = "Forrest Gump", Genre = "Drama", Director = "Robert Zemeckis", Date = new DateTime(1994, 7, 6) });
            movies.Add(new Movie() { Name = "The Matrix", Genre = "Sci-Fi", Director = "Wachowski Brother and Sister", Date = new DateTime(1999, 3, 31) });
            movies.Add(new Movie() { Name = "The Avengers", Genre = "Action", Director = "Joss Wedon", Date = new DateTime(2012, 5, 2) });

            return movies;
        }


    }

}


