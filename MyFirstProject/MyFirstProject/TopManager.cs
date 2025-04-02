using MyFirstProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public class TopManager : IManagementEmployee, ITopManagementEmployee
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public int KPI { get; set; }

        public void Dismiss(IEvaluatedEmployee employee)
        {
            Console.WriteLine($"Employee {employee} was dismissed");
        }

        public void Evaluate(IEvaluatedEmployee employee)
        {
            Random random = new Random();
            employee.KPI = random.Next(10, 100);
        }
    }
}
