using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeesInformation.Models
{
    public class Redeployment
    {
        [Key]
        public int Id { get; set; }

        public int EmployeeID { get; set; }
        public int FromDepartmentID { get; set; }
        public int ToDepartmentID { get; set; }
        public int FromPositionID { get; set; }
        public int ToPositionID { get; set; }
        public DateTime Time { get; set; }
    }
}
