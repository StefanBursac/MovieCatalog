﻿using System;
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
        private List<string> movieList;
        
        public MainWindow()
        {
            

            InitializeComponent();
            
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

            Close();
                  

            
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

        public List<string> MovieCollection
        {
            get { return movieList; }
            set { movieList = value; }
        }
    }
}