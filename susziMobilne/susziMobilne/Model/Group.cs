using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susziMobilne.Model
{

    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public string Key { get; set; }

    }
}
