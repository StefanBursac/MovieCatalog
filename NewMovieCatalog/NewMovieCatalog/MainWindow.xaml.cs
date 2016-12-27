using Microsoft.Win32;
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AddEditWindow addWindow = new AddEditWindow();
 
            if (addWindow.ShowDialog().Value == true)
            {
                movieList.AllMovies.Add(addWindow.Movie);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            AddEditWindow editWindow = new AddEditWindow();
            editWindow.ShowDialog();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {       
            movieList.AllMovies.Remove((Movie)dataGrid.SelectedItem);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "XML file (*.xml)|*.xml|JSON file (*.json)|*.json";
            saveDialog.ShowDialog();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "XML file (*.xml)|*.xml|JSON file (*.json)|*.json";
            openFile.ShowDialog();
        }
    }

}
