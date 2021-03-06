﻿using System;
using System.Collections.ObjectModel;

namespace WpfPractice.src.Model
{
    public class Task
    {
        String _name;
        String _description;
        DateTime _dueDate;
        ObservableCollection<Subtask> _subtaskList;
        ObservableCollection<Subtask> _doneSubtaskList;
        Employee _employee;

        public Task()
        {
            Name = "[EMPTY]";
            Description = "[EMPTY]";
            DueDate = DateTime.Now;
            SubtaskList = new ObservableCollection<Subtask>();
            DoneSubtaskList = new ObservableCollection<Subtask>();
            Employee = null;
        }

        public String Name { get => _name; set => _name = value; }
        public String Description { get => _description; set => _description = value; }
        public DateTime DueDate { get => _dueDate; set => _dueDate = value; }

        public ObservableCollection<Subtask> SubtaskList
        {
            get => _subtaskList;
            set
            {
                _subtaskList = value;
            }
        }

        public ObservableCollection<Subtask> DoneSubtaskList
        {
            get => _doneSubtaskList;
            set
            {
                _doneSubtaskList = value;
            }
        }

        public Employee Employee { get => _employee; set => _employee = value; }
    }
}
