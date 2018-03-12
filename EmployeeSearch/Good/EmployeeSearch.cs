using System.Collections.Generic;

namespace SOLID.EmployeeSearch.Good
{
    public class EmployeeSearch
    {
        public IEnumerable<Employee> DataSource { get; set; }

        public EmployeeSearch(IEnumerable<Employee> dataSource)
        {
            DataSource = dataSource;
        }

        public IEnumerable<Employee> By(ISearchCondition condition)
        {
            return condition.Apply(this.DataSource);
        }
    }
}
