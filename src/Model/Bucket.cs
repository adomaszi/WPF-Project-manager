using System;
using System.Collections.Generic;
using System.Text;

namespace WpfPractice.src.Model
{
    public class Bucket
    {
        String _name;
        List<Task> _tasks;

        public Bucket()
        {
            _name = "[NO NAME]";
            _tasks = new List<Task>();
        }

        public string Name { get => _name; set => _name = value; }
        public List<Task> Tasks { get => _tasks; set => _tasks = value; }
    }
}
