using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Interfaces
{
    public interface IEvaluatedEmployee : IEmloyee
    {
        public int KPI { get; set; }

    }
}
