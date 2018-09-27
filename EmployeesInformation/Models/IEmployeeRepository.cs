using System.Collections;

namespace EmployeesInformation.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable GetEmployees();
        void Add(Employee Employee);
        void Edit(Employee Employee);
        Employee FindById(int Id);
    }
}
