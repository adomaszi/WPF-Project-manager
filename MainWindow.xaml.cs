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
using WpfPractice.src.Storage;

namespace WpfPractice.src.View
{
    /// <summary>
    /// Interaction logic for WindowMain.xaml
    /// </summary>
    public partial class WindowMain : Window
    {
       // ProjectOverviewView _projectOverview;
       // EmployeeOverviewView _employeeOverviewView;
        StorageClass _storage;
        ProjectOverviewView _projectOverviewView;
        public WindowMain()
        {

            _storage = new StorageClass();
            _projectOverviewView = new ProjectOverviewView(_storage.Projects);
            InitializeComponent();
            ProjectOverviewTabItem.Content = _projectOverviewView;
        }

        private void OpenProjectOverview(object sender, RoutedEventArgs e)
        {
            ProjectOverviewTabItem.Content = _projectOverviewView;
        }
    }
}
