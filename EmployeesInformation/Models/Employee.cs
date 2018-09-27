using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeesInformation.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public int Salary { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }
    }
}
