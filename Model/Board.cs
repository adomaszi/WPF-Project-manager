
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WpfPractice.ModelView;

namespace WpfPractice.Model
{
    public class Board
    {
        private string _name;
        private string _decription;
        private List<Task> _tasks = new List<Task>();
        private List<Person> _members = new List<Person>();
        private ObservableCollection<Silo> _silos = new ObservableCollection<Silo>();

        public Board(string name, string decription)
        {
            Name = name;
            Decription = decription;
        }

        public ObservableCollection<Silo> Silos { get => _silos; set => _silos = value; }
        public string Name { get => _name; set => _name = value; }
        public string Decription { get => _decription; set => _decription = value; }

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
