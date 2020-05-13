using System;
using System.Collections.Generic;
using System.Text;

namespace WpfPractice.Model
{
    class Todo
    {
        private string _taskName;
        private bool _isComplete = false;

        public Todo(string taskName)
        {
            _taskName = taskName;
        }

        public string TaskName { get => _taskName; set => _taskName = value; }
        public bool IsComplete { get => _isComplete; set => _isComplete = value; }
    }
}

