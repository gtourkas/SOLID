using System.Collections.Generic;
using System.Linq;

namespace SOLID.EmployeeSearch.Good
{
    public class SexSearchCondition : ISearchCondition
    {
        public SexOptions Sex { get; set; }

        public SexSearchCondition(SexOptions sex)
        {
            Sex = sex;
        }

        public IEnumerable<Employee> Apply(IEnumerable<Employee> dataSource)
        {
            return dataSource.Where(_ => _.Sex == Sex);
        }
    }
}
