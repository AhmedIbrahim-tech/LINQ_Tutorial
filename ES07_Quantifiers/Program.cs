using LINQTut_Shared.Repository;



var employees = Repository.LoadEmployees();


#region Any


Console.WriteLine();
Console.WriteLine("+++++++++");
Console.WriteLine("Run Any()");
Console.WriteLine("+++++++++");
Console.WriteLine();

// if any employee name starts with some sequence of letter
var input1 = "jac";
var result1 = employees.Any(e => e.Name.StartsWith(input1, StringComparison.OrdinalIgnoreCase));
Console.WriteLine($"find employee with name starts with '{input1}' result: {result1}");

// if any employee employee salary less tham 1000
var input2 = 10000;
var result2 = employees.Any(e => e.Salary < input2);
Console.WriteLine($"at least one employee with salary less than {input2.ToString("C2")} result: {result2}");

// if any employee with skills less tham 1000
var noOfSkills = 1;
var result3 = employees.Any(e => e.Skills.Count < noOfSkills);
Console.WriteLine($"at least one employee with skill count less than {noOfSkills} result: {result3}");

#endregion


#region All

Console.WriteLine();
Console.WriteLine("+++++++++");
Console.WriteLine("Run All()");
Console.WriteLine("+++++++++");
Console.WriteLine();

var Allemployees = Repository.LoadEmployees();

// if all employees have email defined
var result4 = Allemployees.All(e => !string.IsNullOrWhiteSpace(e.Email));
Console.WriteLine($"All employees have email result: {result4}");

// if all employees have at least 1 skill
var result5 = Allemployees.All(e => e.Skills.Any(x => x.Contains("C#")));
Console.WriteLine($"All employees have c# in their skills list result: {result5}");

#endregion


Console.ReadKey();