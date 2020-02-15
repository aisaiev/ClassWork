using HrDB_DatabaseFirst_FluentApi_02_15.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HrDB_DatabaseFirst_FluentApi_02_15
{
    class Program
    {
        static void Main(string[] args)
        {
            using (HRContext context = new HRContext())
            {
                List<Employees> employees = context.Employees.Where(employee => employee.Salary > 10000)
                    .Include(employee => employee.Job)
                    .Include(employee => employee.Department)
                    .ThenInclude(department => department.Location)
                    .ThenInclude(location => location.Country)
                    .ThenInclude(country => country.Region).ToList();
            }
        }
    }
}
