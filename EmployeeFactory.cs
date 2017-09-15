using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    class EmployeeFactory
    {

        public static Employee loadEmployee()
        {
            return new Employee(10, "Rohith", "Fulltime");
        }
    }
}
