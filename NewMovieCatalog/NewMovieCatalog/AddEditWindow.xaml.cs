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
        public Movie Movie { get; set; }


        public AddEditWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            Movie = new Movie();
            Movie.MovieName = textBoxMovieName.Text;
            Movie.Director = textBoxDirector.Text;
            // Movie Genre
            Movie.Date = Date.SelectedDate.GetValueOrDefault();
            DialogResult = true;
            Close();
        }

        private void textBoxMovieName_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }


}
