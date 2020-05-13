using System.Windows;
using System.Windows.Media;

namespace WpfPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.FontFamily = new FontFamily("Segoe UI");
        }
    }
}
