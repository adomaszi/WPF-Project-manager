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
    class BucketViewModel : INotifyPropertyChanged, INotifyCollectionChanged
    {
        private Bucket _bucket;
        public Bucket Bucket { get => _bucket; set => _bucket = value; }
        private Task _selectedTask;
        public Task SelectedTask { get => _selectedTask; set { _selectedTask = value; OnPropertyChanged("SelectedTask"); } }
        private ObservableCollection<Task> _tasks;
        public ObservableCollection<Task> Tasks { get => _tasks; set { _tasks = value;} }
        public BucketViewModel(Bucket bucket)
        {
            _bucket = bucket;
            _tasks = bucket.Tasks;
            Tasks.CollectionChanged += this.OnCollectionChanged;

            AddTaskCommand.EventHandler += AddTaskEventHandler;
            DeleteTaskCommand.EventHandler += DeleteTaskEventHandler;
        }

        // *****************************************************************************
        // BINDING UPDATES
        // *****************************************************************************
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //Get the sender observable collection
            ObservableCollection<TaskViewModel> obsSender = sender as ObservableCollection<TaskViewModel>;
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
        private EventHandlerCommand _addTaskCommand = new EventHandlerCommand();
        public EventHandlerCommand AddTaskCommand
        {
            get { return _addTaskCommand; }
        }
        public void AddTaskEventHandler(object parameter)
        {
            Tasks.Add(new Task());
        }
        private EventHandlerCommand _deleteTaskCommand = new EventHandlerCommand();
        public EventHandlerCommand DeleteTaskCommand
        {
            get { return _deleteTaskCommand; }
        }

        public void DeleteTaskEventHandler(object parameter)
        {
            Tasks.Remove(SelectedTask);
            OnPropertyChanged();
        }

    }
}
