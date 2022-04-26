using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class EmployeeSkill
    {
        public int EmployeeSkillId { get; set; }

        [Required]
        public int Level { get; set; }

        public int? YearsOfExperience { get; set; }

        [Required]
        public Decimal HourlyWage { get; set; }

        //FK

        public int EmployeeId { get; set; }

        public int SkillId { get; set; }

        public Employee Employee { get; set; }

        public Skill Skill { get; set; }
    }
}
