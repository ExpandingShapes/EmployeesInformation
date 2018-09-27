using System.Collections;

namespace EmployeesInformation.Models
{
    public interface IDepartmentRepository
    {
        IEnumerable GetDepartments();
        void Add(Department Department);
        void Edit(Department Department);
        Department FindById(int Id);
    }
}
