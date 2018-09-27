using System;
using System.Collections;
using System.Linq;
using EmployeesInformation.Infrastructure;

namespace EmployeesInformation.Models
{
    public class EmployeeRepository : BaseClass, IAbstractInterface<Employee>
    {
        public EmployeeRepository(EmployeesInfoDbContext Context) : base(Context)
        { }

        public IEnumerable GetAllItems()
        {
            return Context.Employees;
        }

        public void Add(Employee Employee)
        {
            Context.Employees.Add(Employee);
            Context.SaveChanges();
        }

        public void Edit(Employee Employee)
        {
            Context.Entry(Employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
        }

        public Employee FindById(int Id)
        {
            Employee Employee;

            try
            {
                Employee = Context.Employees.Skip(Id - 1).FirstOrDefault();
                return Employee;
            }
            catch (Exception Exception)
            {
                System.Diagnostics.Debug.WriteLine(Exception);
                return null;
            }
        }
    }
}
