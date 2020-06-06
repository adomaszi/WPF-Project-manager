using System;
using System.Collections.Generic;
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
using WpfPractice.src.ViewModel;
using WpfPractice.src.Model;

namespace WpfPractice.src.View
{
    /// <summary>
    /// Interaction logic for ProjectOverviewView.xaml
    /// </summary>
    public partial class ProjectOverviewView : UserControl
    {
        private ProjectOverviewViewModel _viewModel;
        public ProjectOverviewView(List<Project> projects)
        {
            _viewModel = new ProjectOverviewViewModel(projects);
            this.DataContext = _viewModel;
            InitializeComponent();
        }
    }
}
