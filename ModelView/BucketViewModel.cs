using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using WpfPractice.Model;

namespace WpfPractice.ModelView
{
    public class BucketViewModel : INotifyPropertyChanged
    {
        private Bucket _bucket;
        public Bucket Bucket { get => _bucket; set => _bucket = value; }
        private Task _selectedTask; 
        public Task SelectedTask { get => _selectedTask; set { _selectedTask = value; OnPropertyChanged("SelectedTask"); } }

        public BucketViewModel(Bucket bucket)
        {
            _bucket = bucket;
            AddTaskCommand.EventHandler += AddTaskEventHandler;
            DeleteTaskCommand.EventHandler += DeleteTaskEventHandler;
        }

        // *****************************************************************************
        // BINDING UPDATES
        // *****************************************************************************
    
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
            _bucket.Tasks.Add(new Task());
        }
        private EventHandlerCommand _deleteTaskCommand = new EventHandlerCommand();
        public EventHandlerCommand DeleteTaskCommand
        {
            get { return _deleteTaskCommand; }
        }

        public void DeleteTaskEventHandler(object parameter)
        {
            _bucket.Tasks.Remove(_selectedTask);
            OnPropertyChanged("Bucket.Tasks");
        }
    }
}
