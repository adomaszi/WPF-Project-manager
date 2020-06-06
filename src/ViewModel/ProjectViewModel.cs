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
        ObservableCollection<BucketViewModel> _buckets = new ObservableCollection<BucketViewModel>();
        public Project Project { get => _project; set => _project = value; }
        public ObservableCollection<BucketViewModel> Buckets { get => _buckets; set => _buckets = value; }

        public ProjectViewModel(Project project)
        {
            Project = project;
            AddBucketCommand.EventHandler += AddBucketEventHandler;
            DeleteBucketCommand.EventHandler += DeleteBucketEventHandler;
            OpenTaskViewCommand.EventHandler += OpenTaskViewEventHandler;


            foreach (Bucket bucket in _project.Buckets)
            {
                _buckets.Add(new BucketViewModel(bucket));
            }
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
            BucketViewModel bucket = parameter as BucketViewModel;
            Buckets.Add(bucket);
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
        public EventHandlerCommand _openTaskView = new EventHandlerCommand();
        public EventHandlerCommand OpenTaskViewCommand
        {
            get { return _openTaskView; }
        }
        public void OpenTaskViewEventHandler(object parameter)
        {
            TaskViewModel task = parameter as TaskViewModel;
            TaskView taskView = new TaskView(task);
            taskView.Show();
        }
    }
}
