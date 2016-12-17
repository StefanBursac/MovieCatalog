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
        Movie m {get; set; }

        public EditDialogWindow()
        {

            InitializeComponent();
            Movie movie = new Movie();
            NameTextBox.Text = movie.Name;
        }
    }
}
