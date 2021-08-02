using System.Collections.Generic;

namespace HW08.Task2.Models
{
    public class Architect : Engineer
    {
        protected override int SalaryCoef => 12;
        protected override int Bonus => 1_000;
        public override List<string> Technologies { get; set; } = new List<string> { "Design patterns", "SOLID", "SCRUM", "Agile" };

        public Architect(string firstName, string lastName, int experience, string responsibilities, string gitHub) : base(firstName, lastName, experience, responsibilities, gitHub) { }
    }
}
