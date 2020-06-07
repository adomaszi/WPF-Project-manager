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
    /// Interaction logic for BucketView.xaml
    /// </summary>
    public partial class BucketView : Window
    {
        BucketViewModel _viewModel;
        public BucketView(Bucket bucket)
        {
            InitializeComponent();
            _viewModel = new BucketViewModel(bucket);
            this.DataContext = _viewModel;
        }
    }
}
