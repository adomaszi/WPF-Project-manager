using System.Windows;
using System.Windows.Media;
using WpfPractice.View;

namespace WpfPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ProjectOverviewView _projectOverviewView;
        public MainWindow()
        {
            InitializeComponent();
            _projectOverviewView = new ProjectOverviewView();
            ProjectOverviewTabItem.Content = _projectOverviewView;
            this.FontFamily = new FontFamily("Segoe UI");
        }

        private void OpenProjectOverview(object sender, RoutedEventArgs e)
        {
            ProjectOverviewTabItem.Content = _projectOverviewView;
        }
    }
}
