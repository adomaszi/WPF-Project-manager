
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WpfPractice.ModelView;

namespace WpfPractice.Model
{
    public class Project
    {
        private string _name;
        private string _description;
        private List<Task> _tasks = new List<Task>();
        private List<Person> _members = new List<Person>();
        private ObservableCollection<Silo> _silos = new ObservableCollection<Silo>();

        public Project(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public ObservableCollection<Silo> Silos { get => _silos; set => _silos = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }

        public void AddList(Silo list)
        {
            _silos.Add(list);
        }

        public void AddProjectMember(Person newMember)
        {
            _members.Add(newMember);
        }

        public void AddTask(Task newTask)
        {
            _tasks.Add(newTask);
        }
    }
}
