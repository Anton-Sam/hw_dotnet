using HW08.Task1.Interfaces;
using System.Collections.Generic;

namespace HW08.Task1.Models
{
    public class ItCompany : ICompanyService<Engineer>
    {
        private List<Engineer> _engineers = new List<Engineer>();
        public string CompanyName { get; set; } = "SaM Solutions";

        public void AddEmployee(Engineer employee) => _engineers.Add(employee);

        public void AddEmployeeRange(IEnumerable<Engineer> employeiees) => _engineers.AddRange(employeiees);

        public IEnumerable<Engineer> GetEmployees() => _engineers;
    }
}
