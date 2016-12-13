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

namespace Movicatalog
{
    /// <summary>
    /// Interaction logic for AddDialogWindow.xaml
    /// </summary>
    public partial class AddDialogWindow : Window
    {
        public AddDialogWindow()
        {
            InitializeComponent();
            
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Calendar_SelectedDatesChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CalendarDayButton_Click(object sender, RoutedEventArgs e)
        {
            
            
          
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder MovieName = new StringBuilder();
            StringBuilder MovieGenre = new StringBuilder();
            StringBuilder MovieDirector = new StringBuilder();
            DatePicker ReleaseDate = new DatePicker();

            MovieName.Append(MovieNametb);
            MovieName.ToString();
            

        }
           

       

            


}
}

