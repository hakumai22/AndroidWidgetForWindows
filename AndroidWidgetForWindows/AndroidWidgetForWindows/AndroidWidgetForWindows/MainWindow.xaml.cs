using System.Windows;

namespace AndroidWidgetForWindows
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

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            // open Page1.Xaml
            Uri uri = new Uri("/Page1.xaml", UriKind.Relative);
            Frame1.Source = uri;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // about window open
            var win = new Window1();
            win.Show();
        }

        private void Import_click(object sender, RoutedEventArgs e)
        {
            //Import button processing
            Uri url = new Uri("Import.xaml", UriKind.Relative);
            Frame1.Source = url;
        }
        private void Download_click(object sender, RoutedEventArgs e)
        {
            //Download button processing
            Uri url = new Uri("Download.xaml", UriKind.Relative);
            Frame1.Source = url;
        }
    }
}