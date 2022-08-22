using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES02_FuncationalProgramming
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Frist_Name { get; set; }
        public string? Last_Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format(
                   $"" + $"{Id}\t" + $"{String.Concat(Frist_Name + " "  + Last_Name).PadRight(15)}\t" + 
                   $"{Salary}\t" + $"{Age}\t" + $"{HireDate.Date.ToShortDateString()}"
                );
        }
    }
}
