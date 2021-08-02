using HW08.Task3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08.Task3.Models
{
    class Junior : Engineer
    {
        
        public override List<string> Technologies { get; set; } = new List<string> { "C#", "ASP .NET Core", "SQL", "HTML5/CSS" };

        public Junior(string firstName, string lastName, int experience, string responsibilities, string gitHub) : base(firstName, lastName, experience, responsibilities, gitHub) {}
    }
}
