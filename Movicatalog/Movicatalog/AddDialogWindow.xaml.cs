using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static Movicatalog.Movie;

namespace Movicatalog
{
    /// <summary>
    /// Interaction logic for AddDialogWindow.xaml
    /// </summary>
    public partial class AddDialogWindow : Window
    {
        public Movie movie
        {
            get; set;
        }
        public AddDialogWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                movie = new Movie();
                movie.Name = Name.Text;
                movie.Director = Director.Text;
                movie.Date = date.SelectedDate.Value;
                this.DialogResult = true;
                this.Close();
            }
            catch (Exception) { }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public Array Genres
        {
            get
            {
                return Enum.GetValues(typeof(Genre));
            }
        }
    }
}