using System;
using System.Collections.Generic;

namespace HW08.Task2.Models
{
    public abstract class Engineer
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Experience { get; set; }
        public string Responsibilities { get; set; }
        public virtual List<string> Technologies { get; set; } = new List<string>();
        public string GitHub { get; set; }
        protected virtual int SalaryCoef { get; } = 1;
        protected virtual int Bonus { get; }
        private const int _fixSalary = 500;

        public Engineer(string firstName, string lastName, int experience, string responsibilities, string gitHub)
        {
            FirstName = firstName;
            LastName = lastName;
            Experience = experience;
            Responsibilities = responsibilities;
            GitHub = gitHub;
            Technologies.Add("English");
        }

        public int GetSalary() => SalaryCoef * _fixSalary + Bonus;

        public override string ToString() => $"Full Name: {FirstName} {LastName}, Experience: {Experience}, Title: {GetType().Name}, Salary: {GetSalary()}, GitHub: {GitHub}";
    }
}
