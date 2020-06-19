using System;
using System.Collections.ObjectModel;

namespace WpfPractice.src.Model
{
    public class Bucket
    {
        String _name;
        ObservableCollection<Task> _tasks;
        ObservableCollection<Task> _doneTasks;


        public Bucket()
        {
            _name = "[NO NAME]";
            _tasks = new ObservableCollection<Task>();
            _doneTasks = new ObservableCollection<Task>();
        }

        public string Name { get => _name; set => _name = value; }
        public ObservableCollection<Task> Tasks { get => _tasks; set => _tasks = value; }
        public ObservableCollection<Task> DoneTasks { get => _doneTasks; set => _doneTasks = value; }
    }
}
