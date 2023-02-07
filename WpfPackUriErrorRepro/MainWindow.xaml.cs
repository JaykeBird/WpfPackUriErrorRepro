using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WpfPackUriErrorRepro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var bim = new BitmapImage(new Uri("pack://application:,,,/SmileyColor.png", UriKind.RelativeOrAbsolute));
            Debug.Print("Smiley image is " + bim.PixelWidth + " wide.");
        }
    }
}
