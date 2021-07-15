using HW08.Task1.Interfaces;
using HW08.Task1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Abstract = HW08.Task2.Models;

namespace HW08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICompanyService<Engineer> companyService = new ItCompany();
            List<Engineer> engineers = new List<Engineer>
            {
                new TeamLeader("Artur","Rutra",7,"Manage","https://github.com/RutArt"),
                new Junior("Anton", "Samovich", 1, "Fix bags", "https://github.com/Anton-Sam"),
                new Senior("Vasya","Zaicev",5,"Develop and manage","https://github.com/ZaiVAS"),
                new Middle("Ivan", "Ivanov", 3, "Develop and support", "https://github.com/IIvanov"),
                new Architect("Vadzim","Papko",9,"Create architecture and manage","https://github.com/VadzimPapko")
            };
            companyService.AddEmployeeRange(engineers);
            companyService.GetEmployees().OrderBy(emp=>emp.Experience).ToList().ForEach(emp => Console.WriteLine($"Company: {companyService.CompanyName},{emp}"));
            companyService.GetEmployees().OrderBy(emp=>emp.GetType().Name).ToList().ForEach(emp => Console.WriteLine($"Company: {companyService.CompanyName},{emp}"));

            //Example of abstract class list (take from Task2)
            List<Abstract.Engineer> engineersAbstract = new List<Abstract.Engineer>();
            engineersAbstract.Add(new Abstract.Junior("Jun", "Junich", 1, "Fix bags", "https://github.com/jun"));
        }
    }
}
