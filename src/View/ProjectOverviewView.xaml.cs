using System.Windows.Controls;
using WpfPractice.src.ViewModel;

namespace WpfPractice.src.View
{
    /// <summary>
    /// Interaction logic for ProjectOverviewView.xaml
    /// </summary>
    public partial class ProjectOverviewView : UserControl
    {
        private ProjectOverviewViewModel _viewModel;
        public ProjectOverviewView()
        {
            _viewModel = new ProjectOverviewViewModel();
            this.DataContext = _viewModel;
            InitializeComponent();
        }
    }
}
