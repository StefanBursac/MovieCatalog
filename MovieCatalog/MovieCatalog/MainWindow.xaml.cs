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

namespace MovieCatalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Full Name: ");
            sb.AppendLine(FullName.Text);
            sb.Append(" Sex? ");
            sb.Append((bool)Male.IsChecked ? "Male" : "Female");
            sb.Append("Computer ");
            sb.Append((bool)Desktop.IsChecked ? "Desktop" : "");
            sb.Append((bool)Laptop.IsChecked ? "Laptop" : "");
            sb.Append((bool)Tablet.IsChecked ? "Tablet" : "");
            sb.Append("Your yob ");
            sb.Append(Job.SelectedItem.ToString());
            sb.Append("Delivery Date");Job.SelectedItem.ToString();
            sb.Append(DeliveryDate.SelectedDate.ToString());
            MessageBox.Show(sb.ToString(), "Results");dzvcbnm, khgdsa\szdghn km,jhgfdsaSDFGHJGRFWASDF

        }

        private void Job_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedJob = e.AddedItems[0];
            MessageBox.Show(selectedJob.ToString());
        }
    }
}
