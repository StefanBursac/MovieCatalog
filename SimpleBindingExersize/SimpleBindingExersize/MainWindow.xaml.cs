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

namespace SimpleBindingExersize
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Movie m = new Movie();
        MainWindowsViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new MainWindowsViewModel();
            DataContext = viewModel;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //string result = string.Empty;
            //foreach (string n in m.movieList)
            //{
            //    result += n;
            //}
            //textBox1.Text = result;
            //m.AddMovie();
         }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //m.movieList.Add(textBox.Text);
            viewModel.ListaStringova.Add(textBox.Text);
        }
    }
}
