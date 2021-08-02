using System.Collections.Generic;

namespace HW08.Task1.Models
{
    class Senior : Engineer
    {
        protected override int SalaryCoef => 5;
        protected override int Bonus => 300;
        public override List<string> Technologies { get; set; } = new List<string> { "C#", "ASP .NET Core", "Front-end", "Managing skills" };

        public Senior(string firstName, string lastName, int experience, string responsibilities, string gitHub) : base(firstName, lastName, experience, responsibilities, gitHub) { }
    }
}
