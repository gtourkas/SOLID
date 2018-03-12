using System.Collections.Generic;
using System.Linq;

namespace SOLID.EmployeeSearch.Bad
{
    public class EmployeeSearchBad
    {
        public IEnumerable<Employee> DataSource { get; set; }

        public EmployeeSearchBad(IEnumerable<Employee> dataSource)
        {
            DataSource = dataSource;
        }

        public IEnumerable<Employee> By(int ageFrom, int ageUntil)
        {
            return this.DataSource.Where(_ => _.Age >= ageFrom && _.Age <= ageUntil);
        }

        public IEnumerable<Employee> By(SexOptions sex)
        {
            return this.DataSource.Where(_ => _.Sex == sex);
        }
    }
}
