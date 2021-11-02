using System;

namespace Lesson2
{
    public class Employee : User
    {
        public Employee()
        {
        }

        public Employee(Guid id, string firstName, string lastName, string jodTitle, string jobDescription,
            double jobSalary, string company, string companyName, string companyCountry, string companyCity,
            string companyAddress)
            : base(id, firstName, lastName, jodTitle, jobDescription, jobSalary)
        {
            Company = company;
            CompanyName = companyName;
            CompanyCountry = companyCountry;
            CompanyCity = companyCity;
            CompanyAddress = companyAddress;
        }

        public string Company;
        public string CompanyName;
        public string CompanyCountry;
        public string CompanyCity;
        public string CompanyAddress;

        public override void GetUserData()
        {
            base.GetUserData();
            Console.WriteLine(
                $"{JodTitle} in {Company} {CompanyName} ({CompanyCountry}, {CompanyCity}, {CompanyAddress}) " +
                $"and my salary {JobSalary}.");
        }
    }
}