using System.Collections.Generic;
using System.Collections.ObjectModel;
using WpfPractice.Model;
using WpfPractice.ModelView;

namespace WpfPractice.Data
{
    public static class ProjectDatabase
    {
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
        static ObservableCollection<Board> _boards = new ObservableCollection<Board>();
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
