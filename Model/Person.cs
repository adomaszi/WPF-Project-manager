using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WpfPractice.Model
{
    public class Person
    {
        private string _name;
        private List<Board> _projects;

        public Person(string name)
        {
            _name = name;
            _projects = new List<Board>();
        }

        public string Name { get => _name; set => _name = value; }
    }
}