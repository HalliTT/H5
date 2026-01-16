using DependencyInversionPrinciple.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.Model
{
    public class Employee
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Position Position { get; set; }
    }
}
