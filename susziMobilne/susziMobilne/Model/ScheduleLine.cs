using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susziMobilne.Model
{
    public class ScheduleLine
    {
        public Guid Id { get; set; }
        public Room Room {get;set;}

        public DateTime Date { get; set; }
        public Subject Subject { get; set; }
    }
}
