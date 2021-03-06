﻿using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfPractice.src.Model;
using WpfPractice.src.Storage;

namespace WpfPractice.src.ViewModel
{
    public class TaskViewModel : INotifyPropertyChanged, INotifyCollectionChanged
    {
        private Task _task;
        private Bucket _bucket;
        private Employee _selectedEmployee;
        private ObservableCollection<Employee> _employees;
        ObservableCollection<Subtask> _subtasks;
        ObservableCollection<Subtask> _doneSubtasks;



        public string CanClickCompleteSubtasks
        {
            get { return _bucket == null ? "False" : "True"; }
            set { }
        }



        public ObservableCollection<Subtask> DoneSubtasks
        {
            get
            {
                return _task.DoneSubtaskList;
            }
            set
            {
                _task.DoneSubtaskList = value;
            }

        }

        public TaskViewModel(Task task, Bucket bucket)
        {
            Bucket = bucket;
            Employees = StorageClass.Employees;
            _task = task;
            _subtasks = _task.SubtaskList;
            _doneSubtasks = _task.DoneSubtaskList;

            _doneCommand = new TaskEventHandlerCommand(this);
            _notDoneCommand = new TaskEventHandlerCommand(this);
            _addSubtaskCommand = new TaskEventHandlerCommand(this);
            _deleteSubtaskCommand = new TaskEventHandlerCommand(this);
            AddSubtaskCommand.EventHandler += AddSubtaskEventHandler;
            DeleteSubtaskCommand.EventHandler += DeleteSubtaskEventHandler;

            DoneCommand.EventHandler += DoneEventHandler;

            NotDoneCommand.EventHandler += NotDoneEventHandler;
        }

        public TaskViewModel(Task task)
        {
            Employees = StorageClass.Employees;
            _task = task;
            _subtasks = _task.SubtaskList;
            _doneCommand = new TaskEventHandlerCommand(this);
            _notDoneCommand = new TaskEventHandlerCommand(this);
            _addSubtaskCommand = new TaskEventHandlerCommand(this);
            _deleteSubtaskCommand = new TaskEventHandlerCommand(this);
            AddSubtaskCommand.EventHandler += AddSubtaskEventHandler;
            DeleteSubtaskCommand.EventHandler += DeleteSubtaskEventHandler;

            DoneCommand.EventHandler += DoneEventHandler;

            NotDoneCommand.EventHandler += NotDoneEventHandler;
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

        public DateTime DueDate
        {
            get => _task.DueDate;
            set
            {
                _task.DueDate = value;
                OnPropertyChanged();
            }
        }
        public Employee Employee
        {
            get => _task.Employee;
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
        private TaskEventHandlerCommand _addSubtaskCommand;
        public TaskEventHandlerCommand AddSubtaskCommand
        {
            get { return _addSubtaskCommand; }
        }
        public void AddSubtaskEventHandler(object parameter)
        {
            if (_bucket != null)
            {
                Subtask subtask = new Subtask();
                _subtasks.Add(subtask);
                if (_bucket.DoneTasks.Remove(_task))
                {
                    _bucket.Tasks.Add(_task);
                }
            }
        }


        private TaskEventHandlerCommand _deleteSubtaskCommand = new TaskEventHandlerCommand();
        public TaskEventHandlerCommand DeleteSubtaskCommand
        {
            get { return _deleteSubtaskCommand; }
        }

        public void DeleteSubtaskEventHandler(object parameter)
        {
            if (_bucket != null)
            {
                Subtasks.Remove(SelectedSubtask);
                if (_task.SubtaskList.Count == 0 && _bucket.Tasks.Remove(_task))
                {
                    _bucket.DoneTasks.Add(_task);
                }
            }

        }

        private TaskEventHandlerCommand _doneCommand;
        public TaskEventHandlerCommand DoneCommand
        {
            get { return _doneCommand; }
        }

        private TaskEventHandlerCommand _notDoneCommand;
        public TaskEventHandlerCommand NotDoneCommand
        {
            get { return _notDoneCommand; }
        }

        public ObservableCollection<Employee> Employees { get => _employees; set => _employees = value; }
        public Employee SelectedEmployee
        {
            get => _task.Employee; set
            {
                Employee e = _task.Employee;
                if (e != null)
                {
                    e.Tasks.Remove(_task);
                }
                _selectedEmployee = value;
                _task.Employee = value;
                if (_task.Employee != null)
                {
                    _task.Employee.Tasks.Add(_task);
                }

                OnPropertyChanged();
            }
        }

        public Bucket Bucket { get => _bucket; set => _bucket = value; }



        public void DoneEventHandler(object parameter)
        {
            Subtask subtask = parameter as Subtask;

            Subtasks.Remove(subtask);
            DoneSubtasks.Add(subtask);
            if (Bucket != null)
            {
                if (Subtasks.Count == 0)
                {
                    if (Bucket.Tasks.Remove(_task))
                    {
                        Bucket.DoneTasks.Add(_task);
                    }
                }
            }

        }

        public void NotDoneEventHandler(object parameter)
        {
            if (Bucket != null)
            {
                Subtask subtask = parameter as Subtask;

                DoneSubtasks.Remove(subtask);
                Subtasks.Add(subtask);

                if (Bucket.DoneTasks.Remove(_task))
                {
                    Bucket.Tasks.Add(_task);
                }
            }
        }

    }
}
