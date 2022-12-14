using LINQTut_Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTut_Shared.Repository
{
    public static class ExtensionFunctional
    {

        public static IEnumerable<Employee> Filter
            (this IEnumerable<Employee> source, Func<Employee, bool> predicate)
        {

            foreach (var employee in source)
            {
                if (predicate(employee))
                {
                    yield return employee;
                }
            }
        }

        public static void Print<T>(this IEnumerable<T> source, string title)
        {
            if (source == null)
                return;
            Console.WriteLine();
            Console.WriteLine("┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
            Console.WriteLine("└───────────────────────────────────────────────────────┘");
            Console.WriteLine();
            foreach (var item in source)
            {
                if (typeof(T).IsValueType)
                    Console.Write($" {item} "); // 1, 2, 3
                else
                    Console.WriteLine(item);
            }


        }


        public static void PrintMeeting<T>(this IEnumerable<T> source, string title)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n{title}\n");
            Console.ForegroundColor = defaultColor;

            foreach (var item in source)
                Console.WriteLine($"{item}");
        }

        public class Print_Space
        {
            public static void Space(string title)
            {
                Console.WriteLine();
                Console.WriteLine("┌───────────────────────────────────────────────────────┐");
                Console.WriteLine($"│   {title.PadLeft(25, ' ')}                           │");
                Console.WriteLine("└───────────────────────────────────────────────────────┘");
                Console.WriteLine();
            }
        }

    }
}