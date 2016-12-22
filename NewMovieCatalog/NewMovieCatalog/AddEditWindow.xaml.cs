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
        


        public AddEditWindow()
        {
            InitializeComponent();
            
           




        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MovieList list = new MovieList();
            Movie m = new Movie();
            m.MovieName = textBoxMovieName.Text;
            m.Director = textBoxDirector.Text;
            list.AllMovies.Add(m);
            Close();
        }
    }


}
