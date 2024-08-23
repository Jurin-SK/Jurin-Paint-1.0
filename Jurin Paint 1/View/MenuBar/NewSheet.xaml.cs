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
    /// Interaction logic for NewSheet.xaml
    /// </summary>
    public partial class NewSheet : Window
    {
        public bool OkPress { get; set; }
        public int WidthNew { get; set; }
        public int HeightNew { get; set; }
        public NewSheet(Window partw)
        {
            Owner = partw;
            InitializeComponent();
        }

        private void ok_but_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OkPress = true;
                WidthNew = Convert.ToInt32(wid.Text);
                HeightNew = Convert.ToInt32(heg.Text);
                Close();
            }
            catch (FormatException)
            {
                hitex.Text = "Invalid Height Format";
                hitex.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                widtex.Text = "Invalid Width Format";
                widtex.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }
        }

        private void cancel_but_Click(object sender, RoutedEventArgs e)
        {
            OkPress = false;
            Close();
        }
    }
}
