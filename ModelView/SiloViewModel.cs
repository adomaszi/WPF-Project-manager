using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using WpfPractice.Model;

namespace WpfPractice.ModelView
{
    class SiloViewModel: INotifyPropertyChanged
    {
        private Bucket _silo;
        public string Name { get => _silo.Name; set => _silo.Name = value; }
        public ObservableCollection<Task> Tasks { get => _silo.Tasks; set => _silo.Tasks = value; }
        
        public SiloViewModel(Bucket list)
        {
            _silo = list;
        }

  

        public SiloViewModel(string name)
        {
            _silo = new Bucket(name);
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
            OnPropertyChanged();
        }

       
        public void RemoveTask(Task task)
        {
            Tasks.Remove(task);
            OnPropertyChanged();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    
}
