using System.Collections.Generic;

namespace HW08.Task1.Models
{
    class Middle : Engineer
    {
        protected override int SalaryCoef => 3;
        public override List<string> Technologies { get; set; } = new List<string> { "C#", "ASP .NET Core", "SOLID", "TypeScript" };

        public Middle(string firstName, string lastName, int experience, string responsibilities, string gitHub) : base(firstName, lastName, experience, responsibilities, gitHub) { }
    }
}
