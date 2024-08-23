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
    /// Interaction logic for ThickDialog.xaml
    /// </summary>
    public partial class ThickDialog : Window
    {
        public double Thick { get; set; }
        public bool OkPress { get; set; }
        public ThickDialog(Window paraentwt)
        {
            Owner = paraentwt;
            InitializeComponent();
        }
        private void ok_but_Click(object sender, RoutedEventArgs e)
        {
            OkPress = true;
            Thick = slider_thick.Value;
            Close();
        }

        private void cancel_but_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
