using System.Windows;
using WpfPractice.src.Model;
using WpfPractice.src.ViewModel;

namespace WpfPractice.src.View
{
    /// <summary>
    /// Interaction logic for ProjectView.xaml
    /// </summary>
    public partial class ProjectView : Window
    {
        ProjectViewModel _viewModel;
        public ProjectView(Project project)
        {
            _viewModel = new ProjectViewModel(project);
            InitializeComponent();
            this.DataContext = _viewModel;
        }
    }
}
