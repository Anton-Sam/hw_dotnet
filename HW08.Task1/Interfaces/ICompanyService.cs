using System.Collections.Generic;

namespace HW08.Task1.Interfaces
{
    interface ICompanyService<T>
    {
        string CompanyName { get; set; }
        void AddEmployee(T employee);
        void AddEmployeeRange(IEnumerable<T> employeiees);
        IEnumerable<T> GetEmployees();
    }
}
