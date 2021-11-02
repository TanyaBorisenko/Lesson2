using System;
using Lesson2.Interfaces;

namespace Lesson2
{
    public abstract class User : IDisplayable
    {
        public string FullName => $"{FirstName} {LastName}";

        public User()
        {
        }

        protected User(Guid id, string firstName, string lastName, string jodTitle, string jobDescription,
            double jobSalary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            JodTitle = jodTitle;
            JobDescription = jobDescription;
            JobSalary = jobSalary;
        }

        public Guid Id;
        public string FirstName;
        public string LastName;
        public string JodTitle;
        public string JobDescription;
        public double JobSalary;

        public virtual void GetUserData()
        {
            Console.WriteLine(
                $"Hello, I am {FullName} ({Id})");
        }
    }
}