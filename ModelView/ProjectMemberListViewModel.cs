using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using WpfPractice.Data;
using WpfPractice.Model;

namespace WpfPractice.ModelView
{

    class ProjectMemberListViewModel : INotifyCollectionChanged
    {

        private ProjectMemberViewModel _selectedItem;
        private ObservableCollection<ProjectMemberViewModel> projectMembers = new ObservableCollection<ProjectMemberViewModel>();

        public event NotifyCollectionChangedEventHandler CollectionChanged;
        List<List<int>> data = new List<List<int>>();


     

        public ProjectMemberViewModel SelectedItem { 
            get => _selectedItem; 
            set
            {
                _selectedItem = value;
            }
        }

        public ObservableCollection<ProjectMemberViewModel> ProjectMembers { get => projectMembers; set => projectMembers = value; }
        public List<List<int>> Data { get => data; set => data = value; }

        public ProjectMemberListViewModel()
        {
            Data.Add(new List<int> { 6, 0, 0, 1, 9, 5, 0, 0, 0});
            Data.Add(new List<int> { 6, 0, 0, 1, 9, 5, 0, 0, 0 });
            Data.Add(new List<int> { 6, 0, 0, 1, 9, 5, 0, 0, 0 });
            Data.Add(new List<int> { 6, 0, 0, 1, 9, 5, 0, 0, 0 });
            Data.Add(new List<int> { 6, 0, 0, 1, 9, 5, 0, 0, 0 });
            Data.Add(new List<int> { 6, 0, 0, 1, 9, 5, 0, 0, 0 });
            Data.Add(new List<int> { 6, 0, 0, 1, 9, 5, 0, 0, 0 });
            Data.Add(new List<int> { 6, 0, 0, 1, 9, 5, 0, 0, 0 });
            Data.Add(new List<int> { 6, 0, 0, 1, 9, 5, 0, 0, 0 });
            ProjectMembers = ProjectDatabase.GetProjectMembers();
  
            Debug.WriteLine("Creating ViewModel");
            ProjectMembers.CollectionChanged += this.OnCollectionChanged;

        }
        void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //Get the sender observable collection
            ObservableCollection<Person> obsSender = sender as ObservableCollection<Person>;
            NotifyCollectionChangedAction action = e.Action;
      
        }

        
    }
}
