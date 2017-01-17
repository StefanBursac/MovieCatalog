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
using Microsoft.Win32;
using System.IO;
using System.Xml.Serialization;
using System.Data;

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
        {   try
            {
                EditDialogWindow editWindow = new EditDialogWindow((Movie)dataGrid.SelectedItem);
                if (editWindow.ShowDialog() == true)
                { 
                    
                    dataGrid.Items.Refresh();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select Movie to Proceed","Select Movie",MessageBoxButton.OK,MessageBoxImage.Information);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;

            result = MessageBox.Show("Are You sure You want to Delete selected Movie","Delete",MessageBoxButton.YesNoCancel,MessageBoxImage.Warning);

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
            result = MessageBox.Show(exitQuestion, exitWindowsTitle, buttons, MessageBoxImage.Exclamation);

            if (result == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void Import_Click(object sender, RoutedEventArgs e)
        {
            
            OpenFileDialog dlg = new OpenFileDialog();
            //dlg.DefaultExt =".xml",;|".json",; Default file extension 
            dlg.Filter = " XML Document(.xml)|*.xml| JSON Document (.json)|*.json"; // Filter files by extension
            dlg.ShowDialog();

            var filename = dlg.FileName;

            XmlSerializer serialiser = new XmlSerializer(dataGrid.ItemsSource.GetType());
            using (var sr = new StreamReader(filename))
            {
                Movies = (ObservableCollection<Movie>)serialiser.Deserialize(sr);
                dataGrid.ItemsSource = Movies;
            }     
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = " XML Document(.xml)|*.xml| JSON Document (.json)|*.json"; // Filter files by extension
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    string fileName = saveFileDialog.FileName;
                    XmlSerializer serialiser = new XmlSerializer(dataGrid.ItemsSource.GetType());

                    TextWriter tw = new StreamWriter(fileName);
                    serialiser.Serialize(tw, Movies);
                }

            }
            catch (Exception) { }
        }
    }
}

