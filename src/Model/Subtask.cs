using System;

namespace WpfPractice.src.Model
{
    public class Subtask
    {
        String _name;
        bool _isDone;

        public Subtask(String name, bool isDone)
        {
            Name = name;
            IsDone = isDone;
        }

        public Subtask()
        {
            Name = null;
            IsDone = false;
        }

        public string Name { get => _name; set => _name = value; }
        public bool IsDone { get => _isDone; set => _isDone = value; }
    }
}
