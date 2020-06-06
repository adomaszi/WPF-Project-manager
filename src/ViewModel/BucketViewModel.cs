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
        private TaskViewModel _selectedTask;
        public TaskViewModel SelectedTask { get => _selectedTask; set { _selectedTask = value; OnPropertyChanged("SelectedTask"); } }
        private ObservableCollection<TaskViewModel> _taskViewModels = new ObservableCollection<TaskViewModel>();
        public ObservableCollection<TaskViewModel> TaskViewModels { get => _taskViewModels; set { _taskViewModels = value;} }
        public BucketViewModel(Bucket bucket)
        {
            _bucket = bucket;
            _bucket.Tasks.ForEach(delegate(Task task) {
                TaskViewModels.Add(new TaskViewModel(task));
            });
            TaskViewModels.CollectionChanged += this.OnCollectionChanged;

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
            TaskViewModels.Add(new TaskViewModel());
        }
        private EventHandlerCommand _deleteTaskCommand = new EventHandlerCommand();
        public EventHandlerCommand DeleteTaskCommand
        {
            get { return _deleteTaskCommand; }
        }

        public void DeleteTaskEventHandler(object parameter)
        {
            TaskViewModels.Remove(SelectedTask);
            OnPropertyChanged("Bucket.Tasks");
        }

    }
}
