using Jurin_Paint_1.View.MenuBar;
using Jurin_Paint_1.View.Tools;
using Microsoft.Win32;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Jurin_Paint_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static class GlobalVars

        {
            public static Color colorfinal = Color.FromRgb(0,0,0);
            public static string status = "";
            public static Point position;
            public static string img_pub;
            public static double thick = 4;
            public static int reshei = 800;
            public static int reswit = 5050;
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void line_draw_Click(object sender, RoutedEventArgs e)
        {
            GlobalVars.status = "line";
        }

        private void canvas_paint_MouseDown(object sender, MouseButtonEventArgs e)
        {
            GlobalVars.position = Mouse.GetPosition(canvas_paint);
        }

        private void canvas_paint_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (GlobalVars.status == "line")
            {
                Point position1 = Mouse.GetPosition(canvas_paint);
                Line line = new Line();
                SolidColorBrush colord = new SolidColorBrush(GlobalVars.colorfinal);
                line.StrokeThickness = GlobalVars.thick;
                line.Stroke = colord;
                line.Fill = colord;
                line.X1 = GlobalVars.position.X;
                line.Y1 = GlobalVars.position.Y;
                line.X2 = position1.X;
                line.Y2 = position1.Y;
                canvas_paint.Children.Add(line);
            }
            else if (GlobalVars.status == "square")
            {
                Point position1 = Mouse.GetPosition(canvas_paint);
                double X2 = position1.X - GlobalVars.position.X;
                double Y2 = position1.Y - GlobalVars.position.Y;
                if (X2 < 0 & Y2 < 0)
                {
                    Rectangle rect = new Rectangle();
                    Canvas.SetTop(rect, position1.Y);
                    Canvas.SetLeft(rect, position1.X);
                    rect.Width = GlobalVars.position.X - position1.X;
                    rect.Height = GlobalVars.position.Y - position1.Y;
                    SolidColorBrush colord = new SolidColorBrush(GlobalVars.colorfinal);
                    rect.Stroke = colord;
                    rect.StrokeThickness = GlobalVars.thick;
                    canvas_paint.Children.Add(rect);
                }
                else if (X2 < 0)
                {
                    Rectangle recta = new Rectangle();
                    Canvas.SetTop(recta, GlobalVars.position.Y);
                    Canvas.SetLeft(recta, position1.X);
                    recta.Width = GlobalVars.position.X - position1.X;
                    recta.Height = Y2;
                    SolidColorBrush colord2 = new SolidColorBrush(GlobalVars.colorfinal);
                    recta.StrokeThickness = GlobalVars.thick;
                    recta.Stroke = colord2;
                    canvas_paint.Children.Add(recta);
                }
                else if (Y2 < 0)
                {
                    Rectangle rect = new Rectangle();
                    Canvas.SetTop(rect, position1.Y);
                    Canvas.SetLeft(rect, GlobalVars.position.X);
                    rect.Width = X2;
                    rect.Height = GlobalVars.position.Y - position1.Y;
                    SolidColorBrush colord = new SolidColorBrush(GlobalVars.colorfinal);
                    rect.StrokeThickness = GlobalVars.thick;
                    rect.Stroke = colord;
                    canvas_paint.Children.Add(rect);
                }
                else
                {
                    Rectangle rect = new Rectangle();
                    Canvas.SetTop(rect, GlobalVars.position.Y);
                    Canvas.SetLeft(rect, GlobalVars.position.X);
                    rect.Width = X2;
                    rect.Height = Y2;
                    SolidColorBrush colord = new SolidColorBrush(GlobalVars.colorfinal);
                    rect.StrokeThickness = GlobalVars.thick;
                    rect.Stroke = colord;
                    canvas_paint.Children.Add(rect);
                }
            }
            else if (GlobalVars.status == "fillsquare") {
                Point position1 = Mouse.GetPosition(canvas_paint);
                double X2 = position1.X - GlobalVars.position.X;
                double Y2 = position1.Y - GlobalVars.position.Y;
                if (X2 < 0 & Y2 < 0)
                {
                    Rectangle rect = new Rectangle();
                    Canvas.SetTop(rect, position1.Y);
                    Canvas.SetLeft(rect, position1.X);
                    rect.Width = GlobalVars.position.X - position1.X;
                    rect.Height = GlobalVars.position.Y - position1.Y;
                    SolidColorBrush colord = new SolidColorBrush(GlobalVars.colorfinal);
                    rect.Fill = colord;
                    canvas_paint.Children.Add(rect);
                }
                else if (X2 < 0)
                {
                    Rectangle recta = new Rectangle();
                    Canvas.SetTop(recta, GlobalVars.position.Y);
                    Canvas.SetLeft(recta, position1.X);
                    recta.Width = GlobalVars.position.X - position1.X;
                    recta.Height = Y2;
                    SolidColorBrush colord2 = new SolidColorBrush(GlobalVars.colorfinal);
                    recta.Fill = colord2;
                    canvas_paint.Children.Add(recta);
                }
                else if (Y2 < 0)
                {
                    Rectangle rect = new Rectangle();
                    Canvas.SetTop(rect, position1.Y);
                    Canvas.SetLeft(rect, GlobalVars.position.X);
                    rect.Width = X2;
                    rect.Height = GlobalVars.position.Y - position1.Y;
                    SolidColorBrush colord = new SolidColorBrush(GlobalVars.colorfinal);
                    rect.Fill = colord;
                    canvas_paint.Children.Add(rect);
                }
                else
                {
                    Rectangle rect = new Rectangle();
                    Canvas.SetTop(rect, GlobalVars.position.Y);
                    Canvas.SetLeft(rect, GlobalVars.position.X);
                    rect.Width = X2;
                    rect.Height = Y2;
                    SolidColorBrush colord = new SolidColorBrush(GlobalVars.colorfinal);
                    rect.Fill = colord;
                    canvas_paint.Children.Add(rect);
                }
            }
            else if (GlobalVars.status == "circle")
            {
                Point position1 = Mouse.GetPosition(canvas_paint);
                double X2 = position1.X - GlobalVars.position.X;
                double Y2 = position1.Y - GlobalVars.position.Y;
                if (X2 < 0 & Y2 < 0)
                {
                    Ellipse circ = new Ellipse();
                    Canvas.SetTop(circ, position1.Y);
                    Canvas.SetLeft(circ, position1.X);
                    circ.Width = GlobalVars.position.X - position1.X;
                    circ.Height = GlobalVars.position.Y - position1.Y;
                    SolidColorBrush colord = new SolidColorBrush(GlobalVars.colorfinal);
                    circ.StrokeThickness = GlobalVars.thick;
                    circ.Stroke = colord;
                    canvas_paint.Children.Add(circ);
                }
                else if (X2 < 0)
                {
                    Ellipse circ = new Ellipse();
                    Canvas.SetTop(circ, GlobalVars.position.Y);
                    Canvas.SetLeft(circ, position1.X);
                    circ.Width = GlobalVars.position.X - position1.X;
                    circ.Height = Y2;
                    SolidColorBrush colord2 = new SolidColorBrush(GlobalVars.colorfinal);
                    circ.StrokeThickness = GlobalVars.thick;
                    circ.Stroke = colord2;
                    canvas_paint.Children.Add(circ);
                }
                else if (Y2 < 0)
                {
                    Ellipse circ = new Ellipse();
                    Canvas.SetTop(circ, position1.Y);
                    Canvas.SetLeft(circ, GlobalVars.position.X);
                    circ.Width = X2;
                    circ.Height = GlobalVars.position.Y - position1.Y;
                    SolidColorBrush colord = new SolidColorBrush(GlobalVars.colorfinal);
                    circ.StrokeThickness = GlobalVars.thick;
                    circ.Stroke = colord;
                    canvas_paint.Children.Add(circ);
                }
                else
                {
                    Ellipse circ = new Ellipse();
                    Canvas.SetTop(circ, GlobalVars.position.Y);
                    Canvas.SetLeft(circ, GlobalVars.position.X);
                    circ.Width = X2;
                    circ.Height = Y2;
                    SolidColorBrush colord = new SolidColorBrush(GlobalVars.colorfinal);
                    circ.StrokeThickness = GlobalVars.thick;
                    circ.Stroke = colord;
                    canvas_paint.Children.Add(circ);
                }
            }
            else if (GlobalVars.status == "fillcircle") {
                Point position1 = Mouse.GetPosition(canvas_paint);
                double X2 = position1.X - GlobalVars.position.X;
                double Y2 = position1.Y - GlobalVars.position.Y;
                if (X2 < 0 & Y2 < 0)
                {
                    Ellipse circ = new Ellipse();
                    Canvas.SetTop(circ, position1.Y);
                    Canvas.SetLeft(circ, position1.X);
                    circ.Width = GlobalVars.position.X - position1.X;
                    circ.Height = GlobalVars.position.Y - position1.Y;
                    SolidColorBrush colord = new SolidColorBrush(GlobalVars.colorfinal);
                    circ.Fill = colord;
                    canvas_paint.Children.Add(circ);
                }
                else if (X2 < 0)
                {
                    Ellipse circ = new Ellipse();
                    Canvas.SetTop(circ, GlobalVars.position.Y);
                    Canvas.SetLeft(circ, position1.X);
                    circ.Width = GlobalVars.position.X - position1.X;
                    circ.Height = Y2;
                    SolidColorBrush colord2 = new SolidColorBrush(GlobalVars.colorfinal);
                    circ.Fill = colord2;
                    canvas_paint.Children.Add(circ);
                }
                else if (Y2 < 0)
                {
                    Ellipse circ = new Ellipse();
                    Canvas.SetTop(circ, position1.Y);
                    Canvas.SetLeft(circ, GlobalVars.position.X);
                    circ.Width = X2;
                    circ.Height = GlobalVars.position.Y - position1.Y;
                    SolidColorBrush colord = new SolidColorBrush(GlobalVars.colorfinal);
                    circ.Fill = colord;
                    canvas_paint.Children.Add(circ);
                }
                else
                {
                    Ellipse circ = new Ellipse();
                    Canvas.SetTop(circ, GlobalVars.position.Y);
                    Canvas.SetLeft(circ, GlobalVars.position.X);
                    circ.Width = X2;
                    circ.Height = Y2;
                    SolidColorBrush colord = new SolidColorBrush(GlobalVars.colorfinal);
                    circ.Fill = colord;
                    canvas_paint.Children.Add(circ);
                }
            }
            else if (GlobalVars.status == "triangle")
            {
                Point position1 = Mouse.GetPosition(canvas_paint);
                Polygon polygon = new Polygon();
                polygon.StrokeThickness = GlobalVars.thick;
                polygon.Stroke = new SolidColorBrush(GlobalVars.colorfinal);
                polygon.Points.Add(GlobalVars.position);
                polygon.Points.Add(position1);
                polygon.Points.Add(new Point(position1.X, GlobalVars.position.Y));
                canvas_paint.Children.Add(polygon);

            }
            else if (GlobalVars.status == "filltriangle")
            {
                Point position1 = Mouse.GetPosition(canvas_paint);
                Polygon polygon = new Polygon();
                polygon.Fill = new SolidColorBrush(GlobalVars.colorfinal);
                polygon.Points.Add(GlobalVars.position);
                polygon.Points.Add(position1);
                polygon.Points.Add(new Point(position1.X, GlobalVars.position.Y));
                canvas_paint.Children.Add(polygon);
            }
            else if (GlobalVars.status == "text")
            {
                TextDialog textdil = new TextDialog(this);
                Opacity = 0.4;
                textdil.ShowDialog();
                Opacity = 1;
                if (textdil.TextInp == "stiamo aspettando")
                {
                    Window1 esteg = new Window1();
                    Opacity = 0.4;
                    esteg.ShowDialog();
                    Opacity = 1;

                }
                Point position1 = Mouse.GetPosition(canvas_paint);
                TextBlock textBlock = new TextBlock();
                textBlock.FontSize = GlobalVars.thick * 10.8;
                textBlock.Text = textdil.TextInp;
                textBlock.Foreground = new SolidColorBrush(GlobalVars.colorfinal);
                Canvas.SetTop(textBlock, GlobalVars.position.Y);
                Canvas.SetLeft(textBlock, GlobalVars.position.X);
                canvas_paint.Children.Add(textBlock);
            }
            else if (GlobalVars.status == "image")
            {
                Point position1 = Mouse.GetPosition(canvas_paint);
                double X2 = position1.X - GlobalVars.position.X;
                double Y2 = position1.Y - GlobalVars.position.Y;
                if (X2 < 0 & Y2 < 0)
                {
                    Rectangle rect = new Rectangle();
                    Canvas.SetTop(rect, position1.Y);
                    Canvas.SetLeft(rect, position1.X);
                    rect.Width = GlobalVars.position.X - position1.X;
                    rect.Height = GlobalVars.position.Y - position1.Y;
                    SolidColorBrush colord = new SolidColorBrush(GlobalVars.colorfinal);
                    rect.Fill = new ImageBrush
                    {
                        ImageSource = new BitmapImage(new Uri(GlobalVars.img_pub, UriKind.Absolute))
                    };
                    canvas_paint.Children.Add(rect);
                }
                else if (X2 < 0)
                {
                    Rectangle recta = new Rectangle();
                    Canvas.SetTop(recta, GlobalVars.position.Y);
                    Canvas.SetLeft(recta, position1.X);
                    recta.Width = GlobalVars.position.X - position1.X;
                    recta.Height = Y2;
                    SolidColorBrush colord2 = new SolidColorBrush(GlobalVars.colorfinal);
                    recta.Fill = new ImageBrush
                    {
                        ImageSource = new BitmapImage(new Uri(GlobalVars.img_pub, UriKind.Absolute))
                    };
                    canvas_paint.Children.Add(recta);
                }
                else if (Y2 < 0)
                {
                    Rectangle rect = new Rectangle();
                    Canvas.SetTop(rect, position1.Y);
                    Canvas.SetLeft(rect, GlobalVars.position.X);
                    rect.Width = X2;
                    rect.Height = GlobalVars.position.Y - position1.Y;
                    SolidColorBrush colord = new SolidColorBrush(GlobalVars.colorfinal);
                    rect.Fill = new ImageBrush
                    {
                        ImageSource = new BitmapImage(new Uri(GlobalVars.img_pub, UriKind.Absolute))
                    };
                    canvas_paint.Children.Add(rect);
                }
                else
                {
                    Rectangle rect = new Rectangle();
                    Canvas.SetTop(rect, GlobalVars.position.Y);
                    Canvas.SetLeft(rect, GlobalVars.position.X);
                    rect.Width = X2;
                    rect.Height = Y2;
                    SolidColorBrush colord = new SolidColorBrush(GlobalVars.colorfinal);
                    rect.Fill = new ImageBrush
                    {
                        ImageSource = new BitmapImage(new Uri(GlobalVars.img_pub, UriKind.Absolute))
                    };
                    canvas_paint.Children.Add(rect);
                }
            }
        }

        private void colordialog_Click(object sender, RoutedEventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog(this);
            Opacity = 0.4;
            colorDialog.ShowDialog();
            Opacity = 1;
            if (colorDialog.OkPress)
            {
                GlobalVars.colorfinal = colorDialog.DrawingColor;
            }
        }

        private void square_draw_Click(object sender, RoutedEventArgs e)
        {
            GlobalVars.status = "square";
        }

        private void fillsquare_draw_Click(object sender, RoutedEventArgs e)
        {
            GlobalVars.status = "fillsquare";
        }

        private void circle_draw_Click(object sender, RoutedEventArgs e)
        {
            GlobalVars.status = "circle";
        }

        private void fillcircle_draw_Click(object sender, RoutedEventArgs e)
        {
            GlobalVars.status = "fillcircle";
        }

        private void triangle_draw_Click(object sender, RoutedEventArgs e)
        {
            GlobalVars.status = "triangle";
        }

        private void filltriangle_draw_Click(object sender, RoutedEventArgs e)
        {
            GlobalVars.status = "filltriangle";
        }

        private void text_draw_Click(object sender, RoutedEventArgs e)
        {
            GlobalVars.status = "text";
        }

        private void image_draw_Click(object sender, RoutedEventArgs e)
        {
                var imageopen = new OpenFileDialog();
            Opacity = 0.4;
                imageopen.FileName = "Image";
                imageopen.DefaultExt = ".jpg";
            imageopen.Filter = "JPG Images (.jpg)|*.jpg|PNG Images (.png)|*.png|JPEG Images (.jpeg)|*.jpeg";
                bool? result = imageopen.ShowDialog();
            Opacity = 1;
                if (result == true)
                {
                GlobalVars.img_pub = imageopen.FileName;
                var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
                timer.Start();
                timer.Tick += (sender, args) =>
                {
                    timer.Stop();
                    GlobalVars.status = "image";
                };
            }

        }

        private void thickness_dialog_Click(object sender, RoutedEventArgs e)
        {
            ThickDialog thickdialog = new ThickDialog(this);
            Opacity = 0.4;
            thickdialog.ShowDialog();
            Opacity = 1;
            if (thickdialog.OkPress)
            {
                GlobalVars.thick = thickdialog.Thick;
            }

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            GithubAbout gitab = new GithubAbout(this);
            Opacity = 0.4;
            gitab.ShowDialog();
            Opacity = 1;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            AboutApp aboutApp = new AboutApp(this);
            Opacity = 0.4;
            aboutApp.ShowDialog();
            Opacity = 1;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            canvas_paint.Children.Clear();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            ColorDialog backcol = new ColorDialog(this);
            Opacity = 0.4;
            backcol.ShowDialog();
            Opacity = 1;
            if (backcol.OkPress)
            {
                canvas_paint.Background = new SolidColorBrush(backcol.DrawingColor);
            }
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            NewSheet newSheet = new NewSheet(this);
            Opacity = 0.4;
            newSheet.ShowDialog();
            Opacity = 1;
            if (newSheet.OkPress)
            {
                canvas_paint.Children.Clear();
                canvas_paint.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                canvas_paint.Width = newSheet.WidthNew;
                canvas_paint.Height = newSheet.HeightNew;
                GlobalVars.reshei = newSheet.HeightNew;
                GlobalVars.reswit = newSheet.WidthNew;
            }
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            Opacity = 0.4;
            saveFileDialog.FileName = "Art";
            saveFileDialog.Filter = "PNG Images (.png)|*.png";
            saveFileDialog.DefaultExt = ".png";
            bool? result = saveFileDialog.ShowDialog();
            Opacity = 1;
            if (result == true)
            {
                // Musel som si pomoct s AI inak to neslo :D
                RenderTargetBitmap rtb = new RenderTargetBitmap((int)canvas_paint.RenderSize.Width,
                    (int)canvas_paint.RenderSize.Height, 96d, 96d, System.Windows.Media.PixelFormats.Default);

                
                DrawingVisual dv = new DrawingVisual();
                using (DrawingContext dc = dv.RenderOpen())
                {
                    
                    dc.DrawRectangle(new VisualBrush(canvas_paint), null, new Rect(new Point(0, 0), new Size(canvas_paint.RenderSize.Width, canvas_paint.RenderSize.Height)));
                }

               
                rtb.Render(dv);

                
                var crop = new CroppedBitmap(rtb, new Int32Rect(0, 0, (int)canvas_paint.RenderSize.Width, (int)canvas_paint.RenderSize.Height));

                BitmapEncoder pngEncoder = new PngBitmapEncoder();
                pngEncoder.Frames.Add(BitmapFrame.Create(crop));

                using (var fs = System.IO.File.OpenWrite(saveFileDialog.FileName))
                {
                    pngEncoder.Save(fs);
                }
            }
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            var imageopen = new OpenFileDialog();
            Opacity = 0.4;
            imageopen.FileName = "Image";
            imageopen.DefaultExt = ".jpg";
            imageopen.Filter = "JPG Images (.jpg)|*.jpg|PNG Images (.png)|*.png|JPEG Images (.jpeg)|*.jpeg";
            bool? result = imageopen.ShowDialog();
            Opacity = 1;
            if (result == true)
            {
                BitmapImage imgbit = new BitmapImage(new Uri(imageopen.FileName, UriKind.Absolute));
                canvas_paint.Children.Clear();
                canvas_paint.Width = imgbit.Width;
                canvas_paint.Height = imgbit.Height;
                canvas_paint.Background = new ImageBrush
                { 
                    ImageSource = imgbit
                };

            }
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}