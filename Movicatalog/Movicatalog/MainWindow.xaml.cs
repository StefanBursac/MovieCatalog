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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Movicatalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Movie> Movies = new ObservableCollection<Movie>();
        
        public MainWindow()
        {   
            InitializeComponent();
            Movies = Movie.GetMovies();

            dataGrid.ItemsSource = Movies;
        }

       private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddDialogWindow addWindow = new AddDialogWindow();
            if (addWindow.ShowDialog() == true)
            {
                Movies.Add(addWindow.movie);
                dataGrid.Items.Refresh();
            }

           
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            EditDialogWindow editMovie = new EditDialogWindow();
            editMovie.ShowDialog();
                     
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("Are you sure ", "Delete Item", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                Movies.Remove((Movie)dataGrid.SelectedItem);
            }

        }



        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            string exitQuestion = "Are You sure You want to Exit?";
            string exitWindowsTitle = "Exit";
            MessageBoxButton buttons = MessageBoxButton.YesNo;
            MessageBoxResult result;
            result = MessageBox.Show(exitQuestion, exitWindowsTitle, buttons, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Close();
            }

        }
    }
}
