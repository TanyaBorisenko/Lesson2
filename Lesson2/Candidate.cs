using System;

namespace Lesson2
{
    public class Candidate : User
    {
        public Candidate()
        {
        }

        public DismissalReason? DismissalReason { get; set; }

        public Candidate(Guid id, string firstName, string lastName, string jodTitle, string jobDescription,
            double jobSalary,
            DismissalReason? dismissalReason) : base(id, firstName, lastName, jodTitle, jobDescription, jobSalary)
        {
            DismissalReason = dismissalReason;
        }

        public override void GetUserData()
        {
            base.GetUserData();

            Console.WriteLine(DismissalReason != null
                ? $"I quit my previous job for a reason of {DismissalReason}"
                : "I have not worked anywhere before");
        }
    }
}