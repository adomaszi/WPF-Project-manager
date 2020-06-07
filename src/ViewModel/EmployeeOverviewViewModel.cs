using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;
using WpfPractice.src.Model;
using WpfPractice.src.Storage;
using WpfPractice.src.View;

namespace WpfPractice.src.ViewModel
{
    class EmployeeOverviewViewModel : INotifyCollectionChanged
    {
        private ObservableCollection<Employee> _employees;
        private ObservableCollection<Project> _projects;

        public EmployeeOverviewViewModel()
        {
            Employees = StorageClass.Employees;
            _projects = StorageClass.Projects;
            Employees.CollectionChanged += OnCollectionChanged;
            OpenTaskViewCommand.EventHandler += OpenTaskViewEventHandler;
            _addEmployeeCommand.EventHandler += AddNewEmployeeEventHandler;
            _deleteEmployeeCommand.EventHandler += DeleteEmployeeEventHandler;
            _unassignTaskCommand.EventHandler += UnassignTaskEventHandler;
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;
        void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //Get the sender observable collection
            ObservableCollection<Project> obsSender = sender as ObservableCollection<Project>;
            NotifyCollectionChangedAction action = e.Action;
        }

        public EventHandlerCommand _openTaskView = new EventHandlerCommand();
        public EventHandlerCommand OpenTaskViewCommand
        {
            get { return _openTaskView; }
        }
        public void OpenTaskViewEventHandler(object parameter)
        {
            Task task = parameter as Task;
            TaskView taskView = new TaskView(new TaskViewModel(task));
            taskView.Show();
        }
       

        public EventHandlerCommand _addEmployeeCommand = new EventHandlerCommand();
        public EventHandlerCommand AddEmployeeCommand
        {
            get { return _addEmployeeCommand; }
        }
        public void AddNewEmployeeEventHandler(object parameter)
        {
            _employees.Add(new Employee());
        }
        
        public EventHandlerCommand _deleteEmployeeCommand = new EventHandlerCommand();
        public EventHandlerCommand DeleteEmployeeCommand
        {
            get { return _deleteEmployeeCommand; }
        }
        public void DeleteEmployeeEventHandler(object parameter)
        {
            Employee employee = parameter as Employee;
            _employees.Remove(employee);
        }
        public EventHandlerCommand _unassignTaskCommand = new EventHandlerCommand();
        public EventHandlerCommand UnassignTaskCommand
        {
            get { return _unassignTaskCommand; }
        }
        public void UnassignTaskEventHandler(object parameter)
        {
            Task task = parameter as Task;
            Employee employee = task.Employee;
            task.Employee = null;
            employee.Tasks.Remove(task);
        }
        

        public ObservableCollection<Employee> Employees { get => _employees; set => _employees = value; }
    }
}
