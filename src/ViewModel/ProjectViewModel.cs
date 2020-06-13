using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using WpfPractice.src.Model;
using WpfPractice.src.View;

namespace WpfPractice.src.ViewModel
{
    class ProjectViewModel : INotifyPropertyChanged, INotifyCollectionChanged
    {
        Project _project;
        ObservableCollection<Bucket> _buckets = new ObservableCollection<Bucket>();
        public Project Project { get => _project; set => _project = value; }
        public ObservableCollection<Bucket> Buckets { get => _buckets; set => _buckets = value; }

        public ProjectViewModel(Project project)
        {
            Project = project;
            AddBucketCommand.EventHandler += AddBucketEventHandler;
            DeleteBucketCommand.EventHandler += DeleteBucketEventHandler;
            OpenBucketViewCommand.EventHandler += OpenBucketViewEventHandler;

            _buckets = _project.Buckets;
      
        }

        // *****************************************************************************
        // BINDING UPDATES
        // *****************************************************************************
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //Get the sender observable collection
            ObservableCollection<Project> obsSender = sender as ObservableCollection<Project>;
            NotifyCollectionChangedAction action = e.Action;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // *****************************************************************************
        // Commands
        // *****************************************************************************
        public EventHandlerCommand _addBucketCommand = new EventHandlerCommand();
        public EventHandlerCommand AddBucketCommand
        {
            get { return _addBucketCommand; }
        }
        public void AddBucketEventHandler(object parameter)
        {
            
            Buckets.Add(new Bucket());
        }
        public EventHandlerCommand _deleteBucketCommand = new EventHandlerCommand();
        public EventHandlerCommand DeleteBucketCommand
        {
            get { return _deleteBucketCommand; }
        }
        public void DeleteBucketEventHandler(object parameter)
        {
            Bucket bucket = parameter as Bucket;
            _project.Buckets.Remove(bucket);
        }
        
        public EventHandlerCommand _openBucketView = new EventHandlerCommand();
        public EventHandlerCommand OpenBucketViewCommand
        {
            get { return _openBucketView; }
        }
        public void OpenBucketViewEventHandler(object parameter)
        {
            Bucket bucket = parameter as Bucket;
            BucketView bucketView = new BucketView(bucket);
            
            bucketView.Show();
        }
    }
}
