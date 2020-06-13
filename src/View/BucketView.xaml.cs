using System.Windows;
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
