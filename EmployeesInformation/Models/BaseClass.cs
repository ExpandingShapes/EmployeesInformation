using EmployeesInformation.Infrastructure;

namespace EmployeesInformation.Models
{
    public class BaseClass
    {
        protected EmployeesInfoDbContext Context;

        public BaseClass(EmployeesInfoDbContext Context)
        {
            this.Context = Context;
        }
    }
}
