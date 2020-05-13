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
        Board _board;

        public BoardViewModel(Board board)
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
            get => _board.Decription;
            set
            {
                _board.Decription = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Silo> Silos
        {
            get => _board.Silos;
            set
            {
                _board.Silos = value;
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
