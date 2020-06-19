using System.Collections.ObjectModel;
using WpfPractice.src.Model;

namespace WpfPractice.src.ViewModel
{
    class EmployeeStatsViewModel
    {
        ObservableCollection<Employee> _employees;
        ObservableCollection<EmployeeStats> _stats = new ObservableCollection<EmployeeStats>();


        public EmployeeStatsViewModel(ObservableCollection<Employee> employees)
        {
            _employees = employees;


            foreach (Employee employee in _employees)
            {
                EmployeeStats stats = new EmployeeStats();
                stats.Employee = employee;

                foreach (Task task in employee.Tasks)
                {
                    if (task.SubtaskList.Count == 0 && task.DoneSubtaskList.Count > 0)
                    {
                        stats.FinishedTasks.Add(task);
                    }
                    else
                    {
                        stats.InProgressTasks.Add(task);
                    }
                }

                _stats.Add(stats);
            }

        }

        public ObservableCollection<EmployeeStats> Stats { get => _stats; set => _stats = value; }

        public class EmployeeStats
        {
            ObservableCollection<Task> _inProgressTasks = new ObservableCollection<Task>();
            ObservableCollection<Task> _finishedTasks = new ObservableCollection<Task>();
            Employee _employee;

            public ObservableCollection<Task> InProgressTasks { get => _inProgressTasks; set => _inProgressTasks = value; }
            public ObservableCollection<Task> FinishedTasks { get => _finishedTasks; set => _finishedTasks = value; }
            public Employee Employee { get => _employee; set => _employee = value; }
        }
    }
}
