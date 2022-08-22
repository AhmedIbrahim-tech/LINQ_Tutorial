#region LINQWhere_Ex01

using ES02_FuncationalProgramming;

var employees = Repository.LoadEmployee();
var FnameStartsWithSwithFilter = employees
    .Filter(x =>
    x.Frist_Name.ToLowerInvariant().StartsWith("s"));

FnameStartsWithSwithFilter.Print("Fname Starts With S / Filter");


Console.WriteLine("\n/******************************************************/\n");


var FnameStartsWithSwithWhere = employees
   .Where(x =>
   x.Frist_Name.ToLowerInvariant().StartsWith("s"));

FnameStartsWithSwithWhere.Print("Fname Starts With S / Where");


#endregion

#region LINQWhere_Ex02


List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//var evenNumbers = numbers.Where(x => x % 2 == 0);
IEnumerable<int> evenNumbers =
    numbers.Where(x => x % 2 == 0); // construction (lazy loading)

numbers.Add(10);
numbers.Add(12);
numbers.Remove(4);

// [1]  ===>   2, 4, 6, 8
// [2]  ===>   2, 6, 8, 10, 12
Console.WriteLine("\n -------------------- Print Even Of List By Where -------------------- \n");
foreach (var n in evenNumbers) // enumeration (immediate execution)
{
    Console.Write($"{n}");
}

#endregion

#region LINQWhere_Ex03


List<int> numbersList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

var evenNumbersUsingExtensionWhere =
    numbersList.Where(x => x % 2 == 0);

var evenNumbersUsingEnumerableWhereMethod =
    Enumerable.Where(numbersList, x => x % 2 == 0);

// Select n fROM numbers where n % 2 = 0;
var evenNumbersUsingQuerySyntax =
     from n in numbersList
     where n % 2 == 0
     select n;


evenNumbersUsingExtensionWhere.Print("evenNumbersUsingExtensionWhere");
evenNumbersUsingEnumerableWhereMethod.Print("evenNumbersUsingEnumerableWhereMethod");
evenNumbersUsingQuerySyntax.Print("evenNumbersUsingQuerySyntax");




#endregion

#region LINQWhere_Ex04


var employeesEx4 = Repository.LoadEmployee();

var empMale = employeesEx4.Where(x => x.Age >= 22);

var empsSalaryOver300K = employeesEx4.Where(x => x.Salary >= 3000);

empMale.Print("Age Employees");

empsSalaryOver300K.Print("Employees with Salary >= 300K");

var empMaleInHRDepartment =
    empMale.Where(x => x.Salary >= 3000 );
empMaleInHRDepartment.Print("Salary Of Employees");

Console.ReadKey();

#endregion
