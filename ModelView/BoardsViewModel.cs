using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;
using WpfPractice.Model;

namespace WpfPractice.ModelView
{
    class BoardsViewModel : INotifyPropertyChanged, INotifyCollectionChanged
    {
        private ObservableCollection<BoardViewModel> _boards = new ObservableCollection<BoardViewModel>();
        private BoardViewModel _selectedItem;
        private TaskViewModel _selectedTask;

        public TaskViewModel SelectedTask { get => _selectedTask; set { _selectedTask = value; OnPropertyChanged(); } }
        public BoardViewModel SelectedItem { get => _selectedItem; set { _selectedItem = value; OnPropertyChanged(); SelectedItem.OnPropertyChanged(); } }
        public ObservableCollection<BoardViewModel> Boards { get => _boards; set => _boards = value; }

        public ICommand dummyCommand()
        {
            return null;
        }

        public BoardsViewModel()
        {
            // Silo is a list of Tasks
            Silo silo = new Silo("Sprint Backlog");
            silo.AddTask(new Task("Create a structure."));
            silo.AddTask(new Task("Establish a relationship."));
            silo.AddTask(new Task("Establish a relationship."));

            // Board is a project
            BoardViewModel board1 = new BoardViewModel(new Project("Board1", "Description of Board1"));

            // Adding two Silos to Board1
            board1.Silos = new ObservableCollection<Silo>() { { silo }, { new Silo("Things To Do") } };
            // Add the board to the list
            _boards.Add(board1);
            BoardViewModel board2 = new BoardViewModel(new Project("Board2", "Description of Board2"));
            
            _boards.Add(board2);
            // Make sure the changes are reflected
            Boards.CollectionChanged += this.OnCollectionChanged;
            _selectedItem = board1;
        }


        public event NotifyCollectionChangedEventHandler CollectionChanged;
        void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //Get the sender observable collection
            ObservableCollection<BoardViewModel> obsSender = sender as ObservableCollection<BoardViewModel>;
            NotifyCollectionChangedAction action = e.Action;

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
    }

}
