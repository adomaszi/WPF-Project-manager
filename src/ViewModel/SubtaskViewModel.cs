using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfPractice.src.Model;

namespace WpfPractice.src.ViewModel
{
    public class SubtaskViewModel : INotifyPropertyChanged
    {
        Subtask _subtask;

        public SubtaskViewModel(Subtask subtask)
        {
            Subtask = subtask;
        }

        public Subtask Subtask { get => _subtask; set => _subtask = value; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
