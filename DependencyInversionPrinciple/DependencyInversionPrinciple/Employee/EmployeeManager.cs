using DependencyInversionPrinciple.Enums;
using DependencyInversionPrinciple.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.Employee
{
    public class EmployeeManager : IEmployeeSearchable
    {
        private readonly List<Model.Employee> _employees;

        public EmployeeManager()
        {
            _employees = new List<Model.Employee>();
        }

        public void AddEmployee(Model.Employee employee)
        {
            _employees.Add(employee);
        }

        public IEnumerable<Model.Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position)
            => _employees.Where(emp => emp.Gender == gender && emp.Position == position);
    }
}
