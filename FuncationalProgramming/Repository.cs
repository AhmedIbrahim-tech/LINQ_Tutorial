using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncationalProgramming
{
    public static class Repository
    {
        public static IEnumerable<Employee> LoadEmployee()
        {
            return new List<Employee>
            {
                new Employee {Id = 103 , Frist_Name = "Mahmoud" , Last_Name = "Eprahim" , Age = 28 , Salary= 7000M , HireDate = DateTime.Now},
                new Employee {Id = 101 , Frist_Name = "Ahmed" , Last_Name = "Eprahim" , Age = 24 , Salary= 5500M , HireDate = DateTime.Now},
                new Employee {Id = 102 , Frist_Name = "Moh" , Last_Name = "Eprahim" , Age = 21 , Salary= 4000M , HireDate = DateTime.Now},
                new Employee {Id = 104 , Frist_Name = "Sara" , Last_Name = "Eprahim" , Age = 24 , Salary= 3000M , HireDate = DateTime.Now},
            };
        }
    }
}
