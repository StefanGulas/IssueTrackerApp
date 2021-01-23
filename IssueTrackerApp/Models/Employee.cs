using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTrackerApp.Models
{
    public class Employee
    {
        public Employee()
        {

        }
        public int EmployeeId { get; set; }
        public enum CompanyFunction
        {
            Developer,
            ProjectManager,
            Manager,
            ProductOwner,
            Tester
        }
        public CompanyFunction Function { get; set; }

    }
}
