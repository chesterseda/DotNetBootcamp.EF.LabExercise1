using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Shift
    {
        public int ShiftId { get; set; }

        [Required]
        public int DayOfWeek { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public short NumberOfEmployees { get; set; }

        [Required]
        public bool Active { get; set; }

        public string? Notes { get; set; }

        //FK

        public int PlacementContractId { get; set; }

        public PlacementContract PlacementContract { get; set; }

        //Many-to-Many

        public ICollection<Schedule> Schedules { get; set; }
    }
}
