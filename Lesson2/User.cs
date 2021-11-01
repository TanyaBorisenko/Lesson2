using System;
using Lesson2.Interfaces;

namespace Lesson2
{
    public abstract class User : IDisplayable
    {
        public Guid Id;
        public string FirstName;
        public string LastName;
        public string JodTitle;
        public string JobDescription;
        public double JobSalary;

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

        public virtual void GetUserData()
        {
            Console.WriteLine(
                $"Hello, I am {FullName}. I want to be a {JodTitle} ({JobDescription}) with a salary from {JobSalary}");
        }
    }
}