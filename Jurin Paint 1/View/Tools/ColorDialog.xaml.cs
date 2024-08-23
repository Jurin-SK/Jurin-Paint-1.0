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

namespace Jurin_Paint_1.View.Tools
{
    /// <summary>
    /// Interaction logic for ColorDialog.xaml
    /// </summary>
    public partial class ColorDialog : Window
    {
        public bool OkPress { get; set; }
        public Color DrawingColor { get; set; }
        public ColorDialog(Window parentw)
        {
            Owner = parentw;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OkPress = false;
            Close();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte rr = (byte)RED.Value;
            byte bb = (byte)BLUE.Value;
            byte gg = (byte)GREEN.Value;
            byte aa = (byte)ALPHA.Value;
            Color cc = Color.FromArgb(aa, rr, gg, bb);
            SolidColorBrush colord = new SolidColorBrush(cc);
            RED.Background = colord; GREEN.Background = colord; BLUE.Background = colord; ALPHA.Background = colord;
        }

        private void GREEN_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte rr = (byte)RED.Value;
            byte bb = (byte)BLUE.Value;
            byte gg = (byte)GREEN.Value;
            byte aa = (byte)ALPHA.Value;
            Color cc = Color.FromArgb(aa, rr, gg, bb);
            SolidColorBrush colord = new SolidColorBrush(cc);
            RED.Background = colord; GREEN.Background = colord; BLUE.Background = colord; ALPHA.Background = colord;
        }

        private void BLUE_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte rr = (byte)RED.Value;
            byte bb = (byte)BLUE.Value;
            byte gg = (byte)GREEN.Value;
            byte aa = (byte)ALPHA.Value;
            Color cc = Color.FromArgb(aa, rr, gg, bb);
            SolidColorBrush colord = new SolidColorBrush(cc);
            RED.Background = colord; GREEN.Background = colord; BLUE.Background = colord; ALPHA.Background = colord;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OkPress = true;
            byte rr = (byte)RED.Value;
            byte bb = (byte)BLUE.Value;
            byte gg = (byte)GREEN.Value;
            byte aa = (byte)ALPHA.Value;
            Color cc = Color.FromArgb(aa, rr, gg, bb);
            DrawingColor = cc;
            Close();
        }

        private void ALPHA_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte rr = (byte)RED.Value;
            byte bb = (byte)BLUE.Value;
            byte gg = (byte)GREEN.Value;
            byte aa = (byte)ALPHA.Value;
            Color cc = Color.FromArgb(aa, rr, gg, bb);
            SolidColorBrush colord = new SolidColorBrush(cc);
            RED.Background = colord; GREEN.Background = colord; BLUE.Background = colord; ALPHA.Background = colord;
        }
    }
}
