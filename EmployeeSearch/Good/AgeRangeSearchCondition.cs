using System.Collections.Generic;
using System.Linq;

namespace SOLID.EmployeeSearch.Good
{
    public class AgeRangeSearchCondition : ISearchCondition
    {
        public AgeRange Range { get; set; }

        public AgeRangeSearchCondition(AgeRange range)
        {
            Range = range;
        }

        public IEnumerable<Employee> Apply(IEnumerable<Employee> dataSource)
        {
            return dataSource.Where(_ => _.Age >= Range.From && _.Age <= Range.Till);
        }
    }
}
