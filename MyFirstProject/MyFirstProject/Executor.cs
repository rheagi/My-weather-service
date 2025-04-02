using MyFirstProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public class Executor : IEvaluatedEmployee
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public int KPI { get; set; }
    }
}
