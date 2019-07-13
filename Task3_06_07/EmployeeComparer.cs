using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_06_07
{
    public class EmployeeComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee firstEmployee, Employee secondEmployee)
        {
            if (ReferenceEquals(firstEmployee, secondEmployee)) return true;

            if (firstEmployee is null || secondEmployee is null)
                return false;

            return firstEmployee.FirstName == secondEmployee.FirstName && firstEmployee.LastName == secondEmployee.LastName;
        }

        public int GetHashCode(Employee employee)
        {
            if (employee is null) return 0;

            int hashProductName = employee.FirstName == null ? 0 : employee.FirstName.GetHashCode();

            int hashProductCode = employee.LastName.GetHashCode();

            return hashProductName ^ hashProductCode;
        }
    }
}
