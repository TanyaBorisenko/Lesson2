using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson2.Sort
{
    public class CandidateReportGenerator : IReportGenerator
    {
        public void SortUsers<T>(ref List<T> entities) where T : User
        {
            if (typeof(T) != typeof(Candidate))
            {
                throw new Exception($"This type: {nameof(Candidate)} is not suitable");
            }

            entities = entities.Cast<Candidate>()
                .OrderBy(a => a.JodTitle)
                .ThenBy(a => a.JobSalary)
                .Cast<T>().ToList();
        }
    }
}