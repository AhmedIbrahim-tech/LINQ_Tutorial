using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES04_ProjectionOperation_Select
{
    internal class EmployeeDTO
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"{Name} [{Salary}]";
        }
    }
}
