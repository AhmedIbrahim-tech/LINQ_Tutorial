using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES02_FuncationalProgramming
{
    public static class ExtnensionProcedural
    {

        /*---------------------------- Get Employees With First Name --------------------------------*/
        public static IEnumerable<Employee> GetEmployeesWithFirstNameStartWith(string value)
        {
            var employees = Repository.LoadEmployee();
            foreach (var employee in employees)
            {
                if (employee.Frist_Name.ToLowerInvariant().StartsWith(value.ToLowerInvariant()))
                {
                    yield return employee;
                }
            }
        }

        /*---------------------------- Get Employees With First Name --------------------------------*/
        public static IEnumerable<Employee> GetEmployeesWithFirstNameEndWith(string value)
        {
            var employees = Repository.LoadEmployee();
            foreach (var employee in employees)
            {
                if (employee.Frist_Name.ToLowerInvariant().EndsWith(value.ToLowerInvariant()))
                {
                    yield return employee;
                }
            }
        }

        /*---------------------------- Get Employees With Last Name --------------------------------*/
        public static IEnumerable<Employee> GetEmployeesWithLastNameStartWith(string value)
        {
            var employees = Repository.LoadEmployee();
            foreach (var employee in employees)
            {
                if (employee.Last_Name.ToLowerInvariant().StartsWith(value.ToLowerInvariant()))
                {
                    yield return employee;
                }
            }
        }

        /*---------------------------- Get Employees With Last Name --------------------------------*/
        public static IEnumerable<Employee> GetEmployeesWithLastNameEndWith(string value)
        {
            var employees = Repository.LoadEmployee();
            foreach (var employee in employees)
            {
                if (employee.Last_Name.ToLowerInvariant().EndsWith(value.ToLowerInvariant()))
                {
                    yield return employee;
                }
            }
        }

        /*---------------------------- Get Employees With Hire year --------------------------------*/
        public static IEnumerable<Employee> GetEmployeesWithHireYear(int Year)
        {
            var employees = Repository.LoadEmployee();
            foreach (var employee in employees)
            {
                if (employee.HireDate.Year == Year)
                {
                    yield return employee;
                }
            }
        }

        /*---------------------------- Get Employees With Salary --------------------------------*/
        public static IEnumerable<Employee> GetEmployeesWithSalary(int salary)
        {
            var employees = Repository.LoadEmployee();
            foreach (var employee in employees)
            {
                if (employee.Salary == salary)
                {
                    yield return employee;
                }
            }
        }

        /*---------------------------- Get Employees With Age --------------------------------*/
        public static IEnumerable<Employee> GetEmployeesWithAge(int Age)
        {
            var employees = Repository.LoadEmployee();
            foreach (var employee in employees)
            {
                if (employee.Age == Age)
                {
                    yield return employee;
                }
            }
        }

        /*--------------------------------- Print Emplyee --------------------------------------*/
        public static void Print<T>(IEnumerable<T> source, string title)
        {
            if (source == null)
            {
                return;
            }

            Console.WriteLine();
            Console.WriteLine("┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
            Console.WriteLine("└───────────────────────────────────────────────────────┘");
            Console.WriteLine();
            foreach (var item in source)
                Console.WriteLine(item);
        }
    }
}
