using System;
using Bogus;

namespace Lesson2
{
    public class UserFactory
    {
        public int JobSalary { get; set; }

        public string JobDescription { get; set; }

        public string JodTitle { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public Enum DismissalReason { get; set; }

        public string Company { get; set; }

        public string CompanyCity { get; set; }

        public string CompanyAddress { get; set; }

        public string CompanyCountry { get; set; }

        public string CompanyName { get; set; }

        public Faker<T> GetEntity<T>() where T : User
        {
            Faker<T> entity = null;

            if (typeof(T) == typeof(Employee))
            {
                var employee = new Faker<Employee>()
                    .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                    .RuleFor(u => u.LastName, f => f.Name.LastName())
                    .RuleFor(u => u.Id, f => Guid.NewGuid())
                    .RuleFor(u => u.JodTitle, f => f.Name.JobTitle())
                    .RuleFor(u => u.JobDescription, f => f.Name.JobDescriptor())
                    .RuleFor(u => u.JobSalary, f => f.Random.Int(25, 45000))
                    .RuleFor(u => u.CompanyName, f => f.Company.CompanyName())
                    .RuleFor(u => u.Company, f => f.Company.CompanySuffix())
                    .RuleFor(u => u.CompanyCountry, f => f.Address.Country())
                    .RuleFor(u => u.CompanyCity, f => f.Address.City())
                    .RuleFor(u => u.CompanyAddress, f => f.Address.StreetAddress());

                entity = (Faker<T>) Convert.ChangeType(employee, typeof(Faker<T>));
            }
            else if (typeof(T) == typeof(Candidate))
            {
                var candidate = new Faker<Candidate>()
                    .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                    .RuleFor(u => u.LastName, f => f.Name.LastName())
                    .RuleFor(u => u.Id, f => Guid.NewGuid())
                    .RuleFor(u => u.JodTitle, f => f.Name.JobTitle())
                    .RuleFor(u => u.JobDescription, f => f.Name.JobDescriptor())
                    .RuleFor(u => u.JobSalary, f => f.Random.Int(25, 45000))
                    .RuleFor(n => n.DismissalReason, f => f.PickRandom<DismissalReason>());

                entity = (Faker<T>) Convert.ChangeType(candidate, typeof(Faker<T>));
            }

            return entity;
        }
    }
}