using System.Windows.Controls;
using WpfPractice.src.ViewModel;

namespace WpfPractice.src.View
{
    /// <summary>
    /// Interaction logic for EmployeeOverviewView.xaml
    /// </summary>
    public partial class EmployeeOverviewView : UserControl
    {
        EmployeeOverviewViewModel _viewmodel;
        public EmployeeOverviewView()
        {
            _viewmodel = new EmployeeOverviewViewModel();
            InitializeComponent();
            this.DataContext = _viewmodel;
        }
    }
}
