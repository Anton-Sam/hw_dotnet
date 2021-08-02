using System.Collections.Generic;

namespace HW08.Task2.Models
{
    public class TeamLeader : Engineer
    {
        protected override int SalaryCoef => 8;
        protected override int Bonus => 500;
        public override List<string> Technologies { get; set; } = new List<string> { "C#", "SOLID", "Design patterns", "Managing skills" };

        public TeamLeader(string firstName, string lastName, int experience, string responsibilities, string gitHub) : base(firstName, lastName, experience, responsibilities, gitHub) { }
    }
}
