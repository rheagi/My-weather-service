using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_for_school
{
    internal class School
    {
        public List<Group> Groups { get; set; } = new List<Group>();
        public List<Subject> Subjects { get; set; } = new List<Subject>();
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();

    }
}
