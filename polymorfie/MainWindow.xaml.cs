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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace polymorfie
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



        private void squareButton_Click(object sender, RoutedEventArgs e)
        {
            //Rectangle rect = new Rectangle();
            //rect.Stroke = new SolidColorBrush(Colors.Black);
            //rect.Width = 50;
            //rect.Height = 50;
            //rect.Margin = new Thickness(5);
            //rect.Fill = new SolidColorBrush(Colors.Blue);
            //canvas.Children.Add(rect);

            Square recht = new Square(100, 100);
            recht.DisplayOn(canvas);
        }
    }
}
