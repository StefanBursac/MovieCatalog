using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NewMovieCatalog
{
    /// <summary>
    /// Interaction logic for AddEditWindow.xaml
    /// </summary>
    public partial class AddEditWindow : Window
    {

        Movie movie = new Movie();
        MovieList list = new MovieList();
        

        public AddEditWindow()
        {
            InitializeComponent();
            DataContext = movie; 
            movie.MovieName = "Stefan";
            movie.genre = Movie.Genre.Action;
            movie.Director = "Bursac";
            movie.Date = new DateTime(12/12/2012);
              
        }       

       

        private void button1_Click(object sender, RoutedEventArgs e)
        {   
            movie.MovieName = textBox.Text;
            movie.Director = textBox1.Text;
            list.AllMovies.Add(movie);
            
            Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
