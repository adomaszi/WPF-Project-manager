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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfPractice.src.Model;
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
