using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08.Task1.Models
{
    public static class ItCompanySalaryService
    {
        private static List<Engineer> _engineers = new List<Engineer>();
        public static string Company { get; set; } = "SaM Solutions";
        
        public static void AddEngineer(Engineer engineer) => _engineers.Add(engineer);

        public static IEnumerable<Engineer> GetEngineers() => _engineers.OrderBy(eng=>eng.Experience);

        public static void PrintEngineersInfo()=> GetEngineers().ToList().ForEach(eng => Console.WriteLine($"Company: {Company},{eng}"));
    }
}
