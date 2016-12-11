using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susziMobilne.Model
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }

        public string Description { get; set; }

    }
}