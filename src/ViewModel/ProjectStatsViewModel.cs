using System.Collections.ObjectModel;
using WpfPractice.src.Model;

namespace WpfPractice.src.ViewModel
{
    class ProjectStatsViewModel
    {
        Project _project;

        ObservableCollection<Task> _unassignedTasks = new ObservableCollection<Task>();
        ObservableCollection<Task> _inProgressTasks = new ObservableCollection<Task>();
        ObservableCollection<Task> _finishedTasks = new ObservableCollection<Task>();

        public ProjectStatsViewModel(Project project)
        {
            _project = project;

            foreach (Bucket bucket in _project.Buckets)
            {
                foreach (Task task in bucket.Tasks)
                {
                    _inProgressTasks.Add(task);
                    if (task.Employee == null)
                    {
                        _unassignedTasks.Add(task);
                    }
                }
                foreach (Task task in bucket.DoneTasks)
                {
                    _finishedTasks.Add(task);
                    if (task.Employee == null)
                    {
                        _unassignedTasks.Add(task);
                    }
                }
            }
        }

        public ObservableCollection<Task> UnassignedTasks { get => _unassignedTasks; set => _unassignedTasks = value; }
        public ObservableCollection<Task> InProgressTasks { get => _inProgressTasks; set => _inProgressTasks = value; }
        public ObservableCollection<Task> FinishedTasks { get => _finishedTasks; set => _finishedTasks = value; }
    }
}
