using System;
using System.Collections.Generic;
using System.Text;

namespace WpfPractice.src.Model
{
    public class Project
    {
        String _name;
        String _description;
        List<Bucket> _buckets;

        public Project()
        {
            _name = "[NO NAME]";
            _description = "[NO DESCRIPTION]";
            _buckets = new List<Bucket>();
        }

        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public List<Bucket> Buckets { get => _buckets; set => _buckets = value; }
    }
}
