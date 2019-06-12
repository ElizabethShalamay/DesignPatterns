using System;

namespace DesignPatternsTasks.Builder.Models
{
    [Serializable]
    public class Department
    {
        public string Name { get; set; }
        public int NumberOfEmployees { get; set; }
        public string PhoneNumber { get; set; }
    }
}