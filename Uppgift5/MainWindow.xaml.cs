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

namespace Uppgift5
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

        private void beräknaBtn_Click(object sender, RoutedEventArgs e) 
        {
            //Laddar in en string från tal1TextBox och konvertera string till int
            int tal1 = int.Parse(tal1TextBox.Text);
            int tal2 = int.Parse(tal2TextBox.Text);
            // summerar tal och skickar dessa till summaTextBox
            summaTextBox.Text = (tal1 + tal2).ToString();
        }

        private void rensaBtn_Click(object sender, RoutedEventArgs e)
        {
            summaTextBox.Clear();
            tal1TextBox.Clear();
            tal2TextBox.Clear();
        }
    }
}
