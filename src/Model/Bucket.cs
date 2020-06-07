using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WpfPractice.src.Model
{
    public class Bucket
    {
        String _name;
        ObservableCollection<Task> _tasks;

        public Bucket()
        {
            _name = "[NO NAME]";
            _tasks = new ObservableCollection<Task>();
        }

        public string Name { get => _name; set => _name = value; }
        public ObservableCollection<Task> Tasks { get => _tasks; set => _tasks = value; }
    }
}
