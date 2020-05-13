using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WpfPractice.Model
{
    public class Task
    {
        private string _name;
        private bool _complete;
        private ObservableCollection<Todo> _todos = new ObservableCollection<Todo>();
        public Task(string name)
        {
            Name = name;
        }
        public Task()
        {
        }

        public string Name { get => _name; set => _name = value; }
        public bool Complete { get => _complete; set => _complete = value; }
        internal ObservableCollection<Todo> Todos { get => _todos; set => _todos = value; }
    }
} 