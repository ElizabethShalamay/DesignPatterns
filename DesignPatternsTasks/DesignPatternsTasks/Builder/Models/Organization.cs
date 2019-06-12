using System;
using System.Collections.Generic;

namespace DesignPatternsTasks.Builder.Models
{
    [Serializable]
    public class Organization
    {
        public Organization()
        {
            Departments = new List<Department>();
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public List<Department> Departments { get; set; }
    }
}
