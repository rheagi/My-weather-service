using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Interfaces
{
    public interface IManagementEmployee : IEmloyee, IEvaluatedEmployee
    {
        public void Evaluate(IEvaluatedEmployee employee)
        {
            Random random = new Random();
            employee.KPI = random.Next(10, 100);
        }
    }
}
