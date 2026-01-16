using DependencyInversionPrinciple.Enums;
using DependencyInversionPrinciple.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.Employee
{
    public class EmployeeStatistics
    {
        private readonly IEmployeeSearchable _emp;

        public EmployeeStatistics(IEmployeeSearchable emp)
        {
            _emp = emp;
        }

        public int CountFemaleManagers() =>
            _emp.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
    }
}
