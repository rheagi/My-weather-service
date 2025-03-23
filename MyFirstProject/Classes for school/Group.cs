using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_for_school
{
    public class Group
    {
        public int Number { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
