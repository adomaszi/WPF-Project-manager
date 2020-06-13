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
using System.Windows.Shapes;
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
