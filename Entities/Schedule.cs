using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Schedule
    {
        public int ScheduleId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public Decimal HourlyWage { get; set; }

        [Required]
        public bool Overtime { get; set; }

        //FK

        public int ShiftId { get; set; }

        public int EmployeeId { get; set; }

        public Shift Shift { get; set; }

        public Employee Employee { get; set; }
    }
}
