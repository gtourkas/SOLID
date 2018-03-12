using System.Collections.Generic;

namespace SOLID.EmployeeSearch.Good
{
    public interface ISearchCondition
    {
        IEnumerable<Employee> Apply(IEnumerable<Employee> dataSource);
    }
}