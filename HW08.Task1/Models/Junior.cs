using System.Collections.Generic;

namespace HW08.Task1.Models
{
    class Junior : Engineer
    {
        public override List<string> Technologies { get; set; } = new List<string> { "C#", "ASP .NET Core", "SQL", "HTML5/CSS" };

        public Junior(string firstName, string lastName, int experience, string responsibilities, string gitHub) : base(firstName, lastName, experience, responsibilities, gitHub) { }
    }
}
