using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using WpfPractice.Model;

namespace WpfPractice.ModelView
{
    class TaskViewModel : INotifyPropertyChanged
    {
        private Task _task;
        public string Name { get => _task.Name; set => _task.Name = value; }
        public string Description { get => _task.Description; set => _task.Description = value; }
        internal ObservableCollection<Todo> Todos { get => _task.Todos; set => _task.Todos = value; }

        public TaskViewModel(string name)
        {
            _task = new Task(name);
        }

        public TaskViewModel(Task task)
        {
            _task = task;
        }
        public void ChangeModel(Task task)
        {
            _task = task;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}