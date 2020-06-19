using System.Collections.ObjectModel;
using System.Windows;
using WpfPractice.src.Model;
using WpfPractice.src.ViewModel;

namespace WpfPractice.src.View
{
    /// <summary>
    /// Interaktionslogik für EmployeeStatsView.xaml
    /// </summary>
    public partial class EmployeeStatsView : Window
    {
        EmployeeStatsViewModel _viewModel;
        public EmployeeStatsView(ObservableCollection<Employee> employees)
        {
            _viewModel = new EmployeeStatsViewModel(employees);
            InitializeComponent();
            this.DataContext = _viewModel;
        }
    }
}
