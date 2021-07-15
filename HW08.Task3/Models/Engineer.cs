using HW08.Task3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08.Task3.Models
{
    class Engineer
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Experience { get; set; }
        public string Responsibilities { get; set; }
        public virtual List<string> Technologies { get; set; } = new List<string>();
        public string GitHub { get; set; }

        public Engineer(string firstName, string lastName, int experience, string responsibilities, string gitHub)
        {
            FirstName = firstName;
            LastName = lastName;
            Experience = experience;
            Responsibilities = responsibilities;
            GitHub = gitHub;
            Technologies.Add("English");
        }

        public override string ToString() => $"Full Name: {FirstName} {LastName}, Experience: {Experience}, Title: {GetType().Name}, Salary: {GetSalary()}, GitHub: {GitHub}";

        public int GetSalary()=> SalaryCoef * _fixSalary + Bonus;

    }
}
