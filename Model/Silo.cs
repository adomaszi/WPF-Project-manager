using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WpfPractice.Model
{
    public class Silo
    {
        string _name;
        public ObservableCollection<Task> Tasks { get; set; } = new ObservableCollection<Task>();
        public string Name { get => _name; set => _name = value; }

        public Silo(string name)
        {
            Name = name;
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }
    }
}
