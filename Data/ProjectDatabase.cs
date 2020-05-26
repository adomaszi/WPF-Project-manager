using System.Collections.Generic;
using System.Collections.ObjectModel;
using WpfPractice.Model;
using WpfPractice.ModelView;

namespace WpfPractice.Data
{
    public static class ProjectDatabase
    {
        static public ObservableCollection<Project> GetProjects()
        {
            ObservableCollection<Project> projects = new ObservableCollection<Project>();
            Project p = new Project("Dragon Project", "In this project we inspect dinosaur bones.");
            Bucket b = new Bucket("Demo Bucket");
            b.AddTask(new Task());
            p.AddList(b);
            projects.Add(p);
            projects.Add(new Project("Bird Project", "In this project we inspect Bird bones."));
            projects.Add(new Project("Thesis Project", "In this project we take the data from bird and dinosaur bones and test the hypothesis."));
            return projects;
        }
        static ObservableCollection<ProjectMemberViewModel> _members = new ObservableCollection<ProjectMemberViewModel>();
        static public ObservableCollection<ProjectMemberViewModel> GetProjectMembers()
        {
            _members.Add(new ProjectMemberViewModel(new Person("David")));
            _members.Add(new ProjectMemberViewModel(new Person("Bruice")));
            _members.Add(new ProjectMemberViewModel(new Person("Marry")));
            _members.Add(new ProjectMemberViewModel(new Person("Lorry")));
            _members.Add(new ProjectMemberViewModel(new Person("Michael")));
            _members.Add(new ProjectMemberViewModel(new Person("Don")));
            
            return _members;
        }
        static ObservableCollection<Project> _boards = new ObservableCollection<Project>();
        static public ObservableCollection<ProjectMemberViewModel> k()
        {
            
            _members.Add(new ProjectMemberViewModel(new Person("David")));
            _members.Add(new ProjectMemberViewModel(new Person("Bruice")));
            _members.Add(new ProjectMemberViewModel(new Person("Marry")));
            _members.Add(new ProjectMemberViewModel(new Person("Lorry")));
            _members.Add(new ProjectMemberViewModel(new Person("Michael")));
            _members.Add(new ProjectMemberViewModel(new Person("Don")));

            return _members;
        }
    }
}
