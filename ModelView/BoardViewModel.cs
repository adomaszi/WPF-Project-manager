using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using WpfPractice.Model;

namespace WpfPractice.ModelView
{
    public class BoardViewModel : INotifyPropertyChanged
    {
        Project _board;

        public BoardViewModel(Project board)
        {
            _board = board;
        }

        public string Name { 
            get => _board.Name; 
            set
            { 
                _board.Name = value;
                OnPropertyChanged();
            } 
        }
        public string Decription
        {
            get => _board.Description;
            set
            {
                _board.Description = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Bucket> Silos
        {
            get => _board.Buckets;
            set
            {
                _board.Buckets = value;
                OnPropertyChanged("Lists");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
