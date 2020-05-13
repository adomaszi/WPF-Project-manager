using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using WpfPractice.Model;

namespace WpfPractice.ModelView
{
    public class ProjectMemberViewModel : INotifyPropertyChanged
    {
        private Person projectMember;
        public event PropertyChangedEventHandler PropertyChanged;

        public ProjectMemberViewModel(Person projectMember)
        {
            this.projectMember = projectMember;
        }

        public string Name { 
            get => projectMember.Name; 
            set {
                projectMember.Name = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
