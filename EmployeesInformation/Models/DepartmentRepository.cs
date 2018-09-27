using System;
using System.Collections;
using System.Linq;
using EmployeesInformation.Infrastructure;

namespace EmployeesInformation.Models
{
    public class DepartmentRepository : BaseClass, IAbstractInterface<Department>
    {
        public DepartmentRepository(EmployeesInfoDbContext Context) : base(Context)
        {}

        public IEnumerable GetAllItems()
        {
            return Context.Departments;
        }

        public void Add(Department Department)
        {
            Context.Departments.Add(Department);
            Context.SaveChanges();
        }

        public void Edit(Department Department)
        {
            Context.Entry(Department).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
        }

        public Department FindById(int Id)
        {
            Department Department;

            try
            {
                Department = Context.Departments.Skip(Id - 1).FirstOrDefault();
                return Department;
            }
            catch(Exception Exception)
            {
                System.Diagnostics.Debug.WriteLine(Exception);
                return null;
            }
        }
    }
}
