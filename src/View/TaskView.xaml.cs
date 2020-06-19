using System.Windows;
using WpfPractice.src.ViewModel;

namespace WpfPractice.src.View
{
    /// <summary>
    /// Interaction logic for TaskView.xaml
    /// </summary>
    public partial class TaskView : Window
    {
        TaskViewModel _viewModel;
        public TaskView(TaskViewModel task)
        {
            _viewModel = task;
            InitializeComponent();
            this.DataContext = _viewModel;
        }
    }
}
