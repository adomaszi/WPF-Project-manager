using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WpfPractice.Model
{
    public class Task
    {
        private string _name;
        private string _description;
        private ObservableCollection<Todo> _todos = new ObservableCollection<Todo>();
        public Task(string name)
        {
            Name = name;
        }
        public Task()
        {
        }

        public string Name { get => _name; set => _name = value; }
        internal ObservableCollection<Todo> Todos { get => _todos; set => _todos = value; }
        public string Description { get => _description; set => _description = value; }
    }
} 