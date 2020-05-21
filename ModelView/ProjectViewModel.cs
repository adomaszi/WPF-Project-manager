using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using WpfPractice.Model;

namespace WpfPractice.ModelView
{
    public class ProjectViewModel: INotifyPropertyChanged
    {
        Project _project;
        public ProjectViewModel(Project project)
        {
            Project = project;
        }

        public Project Project { get => _project; set => _project = value; }

        // *****************************************************************************
        // BINDING UPDATES
        // *****************************************************************************

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
