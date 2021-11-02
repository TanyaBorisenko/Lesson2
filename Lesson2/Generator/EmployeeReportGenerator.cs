using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson2.Generator
{
    public class EmployeeReportGenerator : IReportGenerator
    {
        public void SortUsers<T>(ref List<T> entities) where T : User
        {
            if (typeof(T) != typeof(Employee))
            {
                throw new Exception($"This type: {nameof(Employee)} is not suitable");
            }

            entities = entities.Cast<Employee>()
                .OrderBy(b => b.CompanyName)
                .ThenByDescending(b => b.JobSalary)
                .Cast<T>().ToList();
        }
    }
}