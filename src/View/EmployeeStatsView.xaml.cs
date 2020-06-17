using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
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
