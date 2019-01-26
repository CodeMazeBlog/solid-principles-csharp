using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class EmployeeStatistics
    {
        private readonly IEmployeeSerchable _emp;

        public EmployeeStatistics(IEmployeeSerchable emp)
        {
            _emp = emp;
        }

        public int CountFemaleManagers() => 
            _emp.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
    }
}
