using System;
using System.Collections.ObjectModel;

namespace WpfPractice.src.Model
{
    public class Employee
    {
        String _name;
        ObservableCollection<Task> _tasks;

        public Employee()
        {
            _name = "New Employee";
            Tasks = new ObservableCollection<Task>();
        }
        public Employee(String name)
        {
            _name = name;
            Tasks = new ObservableCollection<Task>();
        }

        public string Name { get => _name; set => _name = value; }
        public ObservableCollection<Task> Tasks { get => _tasks; set => _tasks = value; }
    }
}
