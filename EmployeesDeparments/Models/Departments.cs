using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesDepartments.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public List<Employee> Employees { get; set; }

    }
}