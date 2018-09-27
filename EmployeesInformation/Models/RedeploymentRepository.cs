using System;
using System.Collections;
using System.Linq;
using EmployeesInformation.Infrastructure;

namespace EmployeesInformation.Models
{
    public class RedeploymentRepository : BaseClass, IAbstractInterface<Redeployment>
    {
        public RedeploymentRepository(EmployeesInfoDbContext Context) : base(Context)
        { }

        public IEnumerable GetAllItems()
        {
            return Context.Redeployments;
        }

        public void Add(Redeployment Redeployment)
        {
            Context.Redeployments.Add(Redeployment);
            Context.SaveChanges();
        }

        public void Edit(Redeployment Redeployment)
        {
            Context.Entry(Redeployment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
        }

        public Redeployment FindById(int Id)
        {
            Redeployment Redeployment;

            try
            {
                Redeployment = Context.Redeployments.Skip(Id - 1).FirstOrDefault();
                return Redeployment;
            }
            catch (Exception Exception)
            {
                System.Diagnostics.Debug.WriteLine(Exception);
                return null;
            }
        }
    }
}
