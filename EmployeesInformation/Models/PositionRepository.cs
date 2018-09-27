using System;
using System.Collections;
using System.Linq;
using EmployeesInformation.Infrastructure;

namespace EmployeesInformation.Models
{
    public class PositionRepository : BaseClass, IAbstractInterface<Position>
    {
        public PositionRepository(EmployeesInfoDbContext Context) : base(Context)
        { }

        public IEnumerable GetAllItems()
        {
            return Context.Positions;
        }

        public void Add(Position Position)
        {
            Context.Positions.Add(Position);
            Context.SaveChanges();
        }

        public void Edit(Position Position)
        {
            Context.Entry(Position).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
        }

        public Position FindById(int Id)
        {
            Position Position;

            try
            {
                Position = Context.Positions.Skip(Id - 1).FirstOrDefault();
                return Position;
            }
            catch (Exception Exception)
            {
                System.Diagnostics.Debug.WriteLine(Exception);
                return null;
            }
        }
    }
}
