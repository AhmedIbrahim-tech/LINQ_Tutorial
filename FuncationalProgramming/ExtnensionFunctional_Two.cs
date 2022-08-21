using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncationalProgramming
{
    public static class ExtnensionFunctional_Two
    {
        /*---------------------------- Filter All Employees With Predicate --------------------------------*/
        public static IEnumerable<Employee> Filter
            (this IEnumerable<Employee> Sourse ,  Func<Employee , bool> Predicate) 
            // Func<Employee , bool> Predicate = Predicate<Employee> predicate
        {
            // var employees = Repository.LoadEmployee();
            foreach (var employee in Sourse)
            {
                if (Predicate(employee))
                {
                    yield return employee;
                }
            }
        }


        /*--------------------------------- Print Emplyee --------------------------------------*/
        public static void Print<T>(this IEnumerable<T> source, string title)
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
