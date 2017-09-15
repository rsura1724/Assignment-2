using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    class Employee
    {
        public int Empid { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        internal Employee(int Id, string EmpName, string JobType)
        {
            Empid = Id;
            Name = EmpName;
            Type = JobType;
        }

       

    }
}
