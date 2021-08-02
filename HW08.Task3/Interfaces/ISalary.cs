using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08.Task3.Interfaces
{
    interface ISalary
    {
        int SalaryCoef { get; }
        int Bonus { get; }
        const int _fixSalary=500;

        int GetSalary();
    }
}
