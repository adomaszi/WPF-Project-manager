using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WpfPractice.src.Model
{
    public class Project
    {
        String _name;
        String _description;
        ObservableCollection<Bucket> _buckets;

        public Project()
        {
            _name = "[NO NAME]";
            _description = "[NO DESCRIPTION]";
            _buckets = new ObservableCollection<Bucket>();
        }

        public String Name { get => _name; set => _name = value; }
        public String Description { get => _description; set => _description = value; }
        public ObservableCollection<Bucket> Buckets { get => _buckets; set => _buckets = value; }
    }
}
