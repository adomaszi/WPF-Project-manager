using Google.Apis.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using WpfPractice.Data;
using WpfPractice.Model;
using WpfPractice.View;

namespace WpfPractice.ModelView
{
    
    public class ProjectOverviewViewModel : INotifyPropertyChanged, INotifyCollectionChanged
    {
        private ObservableCollection<Project> _projects;
        public ObservableCollection<Project> Projects { get => _projects; set => _projects = value; }
        
        public ProjectOverviewViewModel()
        {
            _projects = ProjectDatabase.GetProjects();
            // Add CustomEventHandler
            _addProjectCommand.EventHandler += AddNewProjectEventHandler;
            _deleteProjectCommand.EventHandler += DeleteProjectEventHandler;
            _openProjectViewCommand.EventHandler += OpenProjectViewEventHandler;
            // Collection changed event handler
            _projects.CollectionChanged += this.OnCollectionChanged;
        }

        // *****************************************************************************
        // BINDING UPDATES
        // *****************************************************************************
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //Get the sender observable collection
            ObservableCollection<Project> obsSender = sender as ObservableCollection<Project>;
            NotifyCollectionChangedAction action = e.Action;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // *****************************************************************************
        // Commands
        // *****************************************************************************
        public EventHandlerCommand _addProjectCommand = new EventHandlerCommand();
        public EventHandlerCommand AddProjectCommand
        {
            get { return _addProjectCommand; }
        }
        public void DeleteProjectEventHandler(object parameter)
        {
            Project project = parameter as Project;
            _projects.Remove(project);
        }

        public EventHandlerCommand _deleteProjectCommand = new EventHandlerCommand();
        public EventHandlerCommand DeleteProjectCommand
        {
            get { return _deleteProjectCommand; }
        }
        public void AddNewProjectEventHandler(object parameter)
        {
            Projects.Add(new Project("", ""));
        }

        public EventHandlerCommand _openProjectViewCommand = new EventHandlerCommand();
        public EventHandlerCommand OpenProjectViewCommand
        {
            get { return _openProjectViewCommand; }
        }
        public void OpenProjectViewEventHandler(object parameter)
        {
            Project project = parameter as Project;
            ProjectView projectView = new ProjectView(new ProjectViewModel(project));
            projectView.Show();
        }
    }
}
