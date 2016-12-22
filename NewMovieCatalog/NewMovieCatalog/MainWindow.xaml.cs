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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewMovieCatalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MovieList movieList = new MovieList();
  
        

        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = movieList.AllMovies;
            movieList.AddMovie();


        }

        public void button_Click(object sender, RoutedEventArgs e)
        {
            AddEditWindow addWindow = new AddEditWindow();
            addWindow.ShowDialog();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           AddEditWindow editWindow = new AddEditWindow();
           
           editWindow.ShowDialog();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void button3_Copy1_Click(object sender, RoutedEventArgs e)
        {
            movieList.AllMovies.Remove((Movie)dataGrid.SelectedItem);
        }
    }

}
