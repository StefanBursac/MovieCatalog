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

namespace Movicatalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
            MovieListDataGrid.ItemsSource = Movie.GetMovies();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            string exitQuestion = "Are You sure You want to Exit?";
            string exitWindowsTitle = "Exit";
            MessageBoxButton buttons = MessageBoxButton.YesNo;
            MessageBoxResult result;
            result = MessageBox.Show(exitQuestion,exitWindowsTitle,buttons,MessageBoxImage.Question);
            
            if (result == MessageBoxResult.Yes )
            {
                Close();     
            }
            else
            {
                
            }

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddDialogWindow addWindow = new AddDialogWindow();
            addWindow.ShowDialog();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            EditDialogWindow editMovie = new EditDialogWindow();
            editMovie.ShowDialog();

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
