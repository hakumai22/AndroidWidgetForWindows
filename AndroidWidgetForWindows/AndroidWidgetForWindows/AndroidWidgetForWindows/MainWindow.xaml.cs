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
            Page1 = new Page1();
            Uri1 = new Uri("Page1.xaml", UriKind.Relative);
        }
        public Uri Uri1 { get; set; }
        public Page1 Page1 { get; }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            Frame1.Navigate(Uri1);
        }
    }
}