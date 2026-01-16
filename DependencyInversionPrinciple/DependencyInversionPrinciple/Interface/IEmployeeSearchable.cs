using DependencyInversionPrinciple.Enums;

namespace DependencyInversionPrinciple.Interface
{
    public interface IEmployeeSearchable
    {
        IEnumerable<Model.Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position);
    }
}
