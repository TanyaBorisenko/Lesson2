using System;
using Lesson2.Sort;

namespace Lesson2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var userFactory = new UserFactory();

            var employees = userFactory.GetEntity<Employee>().Generate(Randomizer.GetRandomNumber(10));
            var candidates = userFactory.GetEntity<Candidate>().Generate(Randomizer.GetRandomNumber(12));

            IReportGenerator candidateReport = new CandidateReportGenerator();
            IReportGenerator employyeReport = new EmployeeReportGenerator();

            candidateReport.SortUsers(ref candidates);
            employyeReport.SortUsers(ref employees);

            employees.ForEach(x => Console.WriteLine(x));
            candidates.ForEach(y => Console.WriteLine(y));
        }
    }
}