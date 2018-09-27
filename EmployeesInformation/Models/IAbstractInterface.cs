using System.Collections;

namespace EmployeesInformation.Models
{
    public interface IAbstractInterface<T>
    {
        IEnumerable GetAllItems();
        void Add(T T);
        void Edit(T T);
        T FindById(int Id);
    }
}
