using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices;
using System.Text;
using WpfPractice.src.Model;

namespace WpfPractice.src.Storage
{
    public class StorageClass
    {
        ObservableCollection<Employee> _employees;
        ObservableCollection<Project> _projects;

        public StorageClass()
        {
            SetUpStorage();
        }

        private void SetUpStorage()
        {
            // Create mock data for testing 
            _projects = new ObservableCollection<Project>(CreateProjects());
            _employees = new ObservableCollection<Employee>(CreateEmployees());
        }

        private List<Project> CreateProjects()
        {
            List<Project> projects = new List<Project>();

            Project project = new Project();
            project.Name = "Bakery";
            project.Description = "Contains tasks related to bakind delicious stuff.";

            CreateBuckets().ForEach(delegate (Bucket bucket)
            {
                project.Buckets.Add(bucket);
            });

            Project project_2 = new Project();
            project_2.Name = "Bakery";
            project_2.Description = "Contains tasks related to bakind delicious stuff.";

            CreateBuckets().ForEach(delegate (Bucket bucket)
            {
                project_2.Buckets.Add(bucket);
            });

            projects.Add(project);
            projects.Add(project_2);

            return projects;
        }

        private List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee rob = new Employee("Rob");
            Employee winnie = new Employee("Winnie");
            Employee bob = new Employee("Bob");

            employees.Add(rob);
            employees.Add(winnie);
            employees.Add(bob);

            return employees;
        }

        private List<Bucket> CreateBuckets()
        {
            List<Bucket> buckets = new List<Bucket>();

            Bucket bucket = new Bucket();
            bucket.Name = "Bakery Building One";

            CreateTasks().ForEach(delegate (Task task)
            {
                bucket.Tasks.Add(task);
            });

            Bucket bucket_2 = new Bucket();
            bucket_2.Name = "Bakery Building One";

            CreateTasks().ForEach(delegate (Task task)
            {
                bucket_2.Tasks.Add(task);
            });

            buckets.Add(bucket);
            buckets.Add(bucket_2);

            return buckets;
        }

        private List<Task> CreateTasks() 
        {
            List<Task> tasks = new List<Task>();
            Task makeBread = new Task();
            makeBread.Name = "Make Bread";
            makeBread.Description = "Bread is tasty. Make it good friend.";

            Subtask subtask = new Subtask("Buy ingredients", false);
            Subtask subtask2 = new Subtask("Mix dry ingredients", false);
            Subtask subtask3 = new Subtask("Mix wet ingredients", false);
            Subtask subtask4 = new Subtask("Mix all ingredients", false);
            Subtask subtask5 = new Subtask("Cook bread", false);

            makeBread.SubtaskList.Add(subtask);
            makeBread.SubtaskList.Add(subtask2);
            makeBread.SubtaskList.Add(subtask3);
            makeBread.SubtaskList.Add(subtask4);
            makeBread.SubtaskList.Add(subtask5);

            Task makeBread_2 = new Task();
            makeBread_2.Name = "Make Bread";
            makeBread_2.Description = "Bread is tasty. Make it good friend.";

            Subtask subtask_2 = new Subtask("Buy ingredients", false);
            Subtask subtask2_2 = new Subtask("Mix dry ingredients", false);
            Subtask subtask3_2 = new Subtask("Mix wet ingredients", false);
            Subtask subtask4_2 = new Subtask("Mix all ingredients", false);
            Subtask subtask5_2 = new Subtask("Cook bread", false);

            makeBread_2.SubtaskList.Add(subtask_2);
            makeBread_2.SubtaskList.Add(subtask2_2);
            makeBread_2.SubtaskList.Add(subtask3_2);
            makeBread_2.SubtaskList.Add(subtask4_2);
            makeBread_2.SubtaskList.Add(subtask5_2);

            Task makeBread_3 = new Task();
            makeBread_3.Name = "Make Bread";
            makeBread_3.Description = "Bread is tasty. Make it good friend.";

            Subtask subtask_3 = new Subtask("Buy ingredients", false);
            Subtask subtask2_3 = new Subtask("Mix dry ingredients", false);
            Subtask subtask3_3 = new Subtask("Mix wet ingredients", false);
            Subtask subtask4_3 = new Subtask("Mix all ingredients", false);
            Subtask subtask5_3 = new Subtask("Cook bread", false);

            makeBread_3.SubtaskList.Add(subtask_3);
            makeBread_3.SubtaskList.Add(subtask2_3);
            makeBread_3.SubtaskList.Add(subtask3_3);
            makeBread_3.SubtaskList.Add(subtask4_3);
            makeBread_3.SubtaskList.Add(subtask5_3);

            tasks.Add(makeBread);
            tasks.Add(makeBread_2);
            tasks.Add(makeBread_3);

            return tasks;
        }
     

        public ObservableCollection<Employee> Employees { get => _employees; set => _employees = value; }
        public ObservableCollection<Project> Projects { get => _projects; set => _projects = value; }
    }
}
