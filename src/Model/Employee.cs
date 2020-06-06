using System;
using System.Collections.Generic;
using System.Text;

namespace WpfPractice.src.Model
{
    public class Employee
    {
        String _name;

        public Employee(String name)
        {
            _name = name;
        }

        public string Name { get => _name; set => _name = value; }
    }
}
