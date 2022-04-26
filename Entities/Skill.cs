using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Skill
    {
        public int SkillId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public bool RequiresTicket { get; set; }

        //FK
        public ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
