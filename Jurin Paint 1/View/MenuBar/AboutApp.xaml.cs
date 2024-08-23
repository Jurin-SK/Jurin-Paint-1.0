using Jurin_Paint_1.View.Tools;
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

namespace Jurin_Paint_1.View.MenuBar
{
    /// <summary>
    /// Interaction logic for AboutApp.xaml
    /// </summary>
    public partial class AboutApp : Window
    {
        public AboutApp(Window paraentwt)
        {
            Owner = paraentwt;
            InitializeComponent();
        }

        private void ok_but_Click(object sender, RoutedEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.D7) || Keyboard.IsKeyDown(Key.NumPad7))
            {
                Window2 cube = new Window2();
                Opacity = 0.4;
                cube.ShowDialog();
                Opacity = 1;
            }
            else
            {
                Close();
            }
        }
    }
}
