using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_for_school
{
    public class Teacher
    {
        public string Name { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public Subject Subject { get; set; }
        public Group Group { get; set; }
    }
}
