using System.Collections;

namespace EmployeesInformation.Models
{
    public interface IRedeploymentRepository
    {
        IEnumerable GetRedeployments();
        void Add(Redeployment Redeployment);
        void Edit(Redeployment Redeployment);
        Redeployment FindById(int Id);
    }
}
