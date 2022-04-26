using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string HomePhone { get; set; }

        [Required]
        public bool Active { get; set; }

        //Many-to-Many Shifts

        public ICollection<Schedule> Schedule { get; set; }

        //Many-to-Many EmployeeSkills

        public ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
