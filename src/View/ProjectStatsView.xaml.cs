using System.Windows;
using WpfPractice.src.Model;
using WpfPractice.src.ViewModel;

namespace WpfPractice.src.View
{
    /// <summary>
    /// Interaction logic for ProjectStatsView.xaml
    /// </summary>
    public partial class ProjectStatsView : Window
    {
        ProjectStatsViewModel _viewModel;
        public ProjectStatsView(Project project)
        {
            _viewModel = new ProjectStatsViewModel(project);
            InitializeComponent();
            this.DataContext = _viewModel;
        }
    }
}
