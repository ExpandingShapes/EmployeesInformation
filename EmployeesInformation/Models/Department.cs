using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeesInformation.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}