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
            EditDialogWindow editMovie = new EditDialogWindow((Movie)dataGrid.SelectedItem);
            editMovie.ShowDialog();

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;

            result = MessageBox.Show("Are You sure You want to Delete selected item","Delete",MessageBoxButton.YesNoCancel,MessageBoxImage.Warning);

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

        private void Import_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            //dlg.DefaultExt =".xml",;|".json",; Default file extension 
            dlg.Filter = " XML Document(.xml)|*.xml| JSON Document (.json)|*.json"; // Filter files by extension
            dlg.ShowDialog();
            string filename = dlg.FileName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Export_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            //dlg.DefaultExt =".xml",;|".json",; Default file extension 
            saveFileDialog.Filter = " XML Document(.xml)|*.xml| JSON Document (.json)|*.json"; // Filter files by extension
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
               
                //switch (saveFileDialog.FilterIndex)
                //{
                //    case 1:
                //        this.button2.Image.Save(fs,
                //           System.Drawing.Imaging.ImageFormat.Jpeg);
                //        break;

                //    case 2:
                //        this.button2.Image.Save(fs,
                //           System.Drawing.Imaging.ImageFormat.Bmp);
                //        break;
                //}

                fs.Close();
            }
        }



    }
}

