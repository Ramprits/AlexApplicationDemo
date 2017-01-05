using System;
using System.Collections.Generic;

namespace AlexApplicationDemo.Models.EmployeeViewModels
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public DateTime  CreatedDate { get; set; } = DateTime.UtcNow;

        public virtual ICollection<Employee> Employees { get; set; }
    }
}