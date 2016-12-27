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

namespace Movicatalog
{
    /// <summary>
    /// Interaction logic for EditDialogWindow.xaml
    /// </summary>
    public partial class EditDialogWindow : Window
    {
        public Movie movie
        {
            get; set;
        }


        public EditDialogWindow(Movie movie)
        {

            InitializeComponent();
            
            textBoxName.Text = movie.Name;

            textBoxDirector.Text = movie.Director;
            textBoxDate.SelectedDate = movie.Date; 
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            movie = new Movie();
            movie.Name = textBoxName.Text;
            movie.Director = textBoxDirector.Text;
            movie.Date = textBoxDate.SelectedDate.Value;
            this.DialogResult = true;
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
