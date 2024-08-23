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
using System.Windows.Shapes;

namespace Jurin_Paint_1.View.MenuBar
{
    /// <summary>
    /// Interaction logic for GithubAbout.xaml
    /// </summary>
    public partial class GithubAbout : Window
    {
        public GithubAbout(Window paraentwt)
        {
            Owner = paraentwt;
            InitializeComponent();
        }

        private void ok_but_Click(object sender, RoutedEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftShift))
            {
                MessageBox.Show("Italy: Čakáme", "EGG", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else 
            {
                Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText("testovacka");
        }
    }
}
