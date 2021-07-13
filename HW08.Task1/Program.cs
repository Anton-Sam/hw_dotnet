using HW08.Task1.Models;
using System;
using System.Collections.Generic;

namespace HW08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Engineer> engineers = new List<Engineer>
            {
                new TeamLeader("Artur","Rutra",7,"Manage","https://github.com/RutArt"),
                new Junior("Anton", "Samovich", 1, "Fix bags", "https://github.com/Anton-Sam"),
                new Senior("Vasya","Zaicev",5,"Develop and manage","https://github.com/ZaiVAS"),
                new Middle("Ivan", "Ivanov", 3, "Develop and support", "https://github.com/IIvanov"),
                new Architect("Vadzim","Papko",9,"Create architecture and manage","https://github.com/VadzimPapko")
            };
            engineers.ForEach(ItCompanySalaryService.AddEngineer);
            ItCompanySalaryService.PrintEngineersInfo();
        }
    }
}
