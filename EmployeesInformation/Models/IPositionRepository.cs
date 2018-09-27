using System.Collections;

namespace EmployeesInformation.Models
{
    public interface IPositionRepository
    {
        IEnumerable GetPositions();
        void Add(Position Position);
        void Edit(Position Position);
        Position FindById(int Id);
    }
}
