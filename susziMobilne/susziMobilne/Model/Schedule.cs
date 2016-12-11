using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susziMobilne.Model
{
    public class Schedule
    {
        public Guid Id { get; set; }
        public List<ScheduleLine> ScheduleLines { get; set; }
        public Group Group { get; set; }
    }
}
