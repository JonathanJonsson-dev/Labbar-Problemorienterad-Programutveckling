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

namespace Uppgift2
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

        // En händelse för klick på knappen BtnShowName
        private void BtnShowName_Click(object sender, RoutedEventArgs e)
        {
            string firstName;
            firstName = txtFirstName.Text;
            MessageBox.Show($"Hej {firstName}! Hoppas du mår bra!");
        }
    }
}
