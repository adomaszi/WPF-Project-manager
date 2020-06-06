using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfPractice.src.Model
{
    public class Task
    {
        String _name;
        String _description;
        DateTime _dueDate;
        List<Subtask> _subtaskList;
        Employee _employee;

        public Task()
        {
            Name = "[EMPTY]";
            Description = "[EMPTY]";
            DueDate = DateTime.Now;
            SubtaskList = new List<Subtask>();
            Employee = null;
        }

        public String Name { get => _name; set => _name = value; }
        public String Description { get => _description; set => _description = value; }
        public DateTime DueDate { get => _dueDate; set => _dueDate = value; }
        public List<Subtask> SubtaskList { get => _subtaskList; set => _subtaskList = value; }
        public Employee Employee { get => _employee; set => _employee = value; }
    }
}
