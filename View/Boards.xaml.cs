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

using System.Diagnostics;
using WpfPractice.Model;
using GalaSoft.MvvmLight.Command;

namespace WpfPractice.View
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Boards : Page
    {
 
        public Boards()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        // In MainPage.xaml.cs 
        private void RefreshClick(object sender, EventArgs e)
        {
            //var vm = (MainViewModel)DataContext;
           // vm.RefreshCommand.Execute(null);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var SelectedTaskEditor = (StackPanel)LayoutRoot.FindName("SelectedTask");
            var button = (Button)sender;
            SelectedTaskEditor.DataContext = button.DataContext;
            Debug.Write("Doing it");
            // another way would be to store the ViewModel in this object.
            // Pass the view model the required data and execute commands
            // But is that correct MVVM?
        }
    }
}
