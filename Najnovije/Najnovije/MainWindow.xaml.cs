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

namespace Najnovije
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> l = new List<string>();
        Movie m = new Movie();
        public MainWindow()
        {   
            InitializeComponent();

            DataContext = m;
            

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            string s = m.AddMovies(textBox.Text);
            l.Add(s);
            //textBox2.Text = s;
            
            foreach (string w in l) { textBox1.Text = w; }
            foreach (string w in l) { m.Name = w; }
            
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.ShowDialog();
           
        }
    }
}
