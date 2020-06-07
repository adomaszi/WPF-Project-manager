using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using WpfPractice.src.Model;

namespace WpfPractice.src.ViewModel
{
    public class TaskViewModel : INotifyPropertyChanged, INotifyCollectionChanged
    {
        private Task _task;
        ObservableCollection<Subtask> _subtasks;

        public TaskViewModel(Task task)
        {
            _task = task;
            _subtasks = _task.SubtaskList;
            
            AddSubtaskCommand.EventHandler += AddSubtaskEventHandler;
            DeleteSubtaskCommand.EventHandler += DeleteSubtaskEventHandler;
        }

        public TaskViewModel()
        {
            _task = new Task();
            _subtasks = _task.SubtaskList;
            Subtasks.CollectionChanged += OnCollectionChanged;

            AddSubtaskCommand.EventHandler += AddSubtaskEventHandler;
            DeleteSubtaskCommand.EventHandler += DeleteSubtaskEventHandler;
        }

        public Subtask SelectedSubtask { get; set; }

        public ObservableCollection<Subtask> Subtasks
        {
            get
            {
                return _subtasks;
            }
            set
            {
                _subtasks = value;
            }
        }

        public DateTime DueDate { get => _task.DueDate; 
            set {
                _task.DueDate = value;
                OnPropertyChanged();
            }
        }
        public Employee Employee { get => _task.Employee;
            set
            {
                _task.Employee = value;
                OnPropertyChanged();
            }
        }
        public String Name
        {
            get => _task.Name;
            set
            {
                _task.Name = value;
                OnPropertyChanged();
            }
        }
        public String Description
        {
            get => _task.Description;
            set
            {
                _task.Description = value;
                OnPropertyChanged();
            }
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
        private EventHandlerCommand _addSubtaskCommand = new EventHandlerCommand();
        public EventHandlerCommand AddSubtaskCommand
        {
            get { return _addSubtaskCommand; }
        }
        public void AddSubtaskEventHandler(object parameter)
        {
            Subtask subtask = new Subtask();
            Subtasks.Add(subtask);
            //OnCollectionChanged(SubtaskViewModels, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));

        }
        private EventHandlerCommand _deleteTaskCommand = new EventHandlerCommand();
        public EventHandlerCommand DeleteSubtaskCommand
        {
            get { return _deleteTaskCommand; }
        }

        public void DeleteSubtaskEventHandler(object parameter)
        {
            Subtasks.Remove(SelectedSubtask);
        }
    }
}
