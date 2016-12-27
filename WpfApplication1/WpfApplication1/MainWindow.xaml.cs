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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   AddWindow addW = new AddWindow();
        public MainWindow()
        {
            InitializeComponent();
            textBoxIme.Text = addW.textBox.Text;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBoxIme2.Text = textBoxIme.Text;
            textBoxPrezime2.Text = textBoxPrezime.Text;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            addW.ShowDialog();
            
        }
    }
}
