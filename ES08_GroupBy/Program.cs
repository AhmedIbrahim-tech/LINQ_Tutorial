using LINQTut_Shared.Repository;

RunGroupByExample();
RunLookupExample();
RunGroupByWithQuerySyntax();




#region Group By
static void RunGroupByExample()
{
    Console.WriteLine();
    Console.WriteLine("+++++++++++++++++++++++");
    Console.WriteLine("GroupBy (Method Syntax");
    Console.WriteLine("+++++++++++++++++++++++");
    Console.WriteLine();

    var employees = Repository.LoadEmployees();

    var result = employees.GroupBy(x => x.Name);

    foreach (var item in result)
    {
        item.Print($"Employee in '{item.Key}' Name");
    }
}
#endregion

#region Group By With QuerySyntax

static void RunGroupByWithQuerySyntax()
{
    Console.WriteLine();
    Console.WriteLine("+++++++++++++++++++++++");
    Console.WriteLine("GroupBy (Query Syntax");
    Console.WriteLine("+++++++++++++++++++++++");
    Console.WriteLine();

    var employees = Repository.LoadEmployees();
    var result = from emp in employees
                 group emp by emp.Name;

    foreach (var item in result)
    {
        item.Print($"Employee in '{item.Key}' Name");
    }
}
#endregion

#region Look up

static void RunLookupExample()
{
    Console.WriteLine();
    Console.WriteLine("+++++++++++++++++++++++");
    Console.WriteLine("ToLookup (Method Syntax");
    Console.WriteLine("+++++++++++++++++++++++");
    Console.WriteLine();

    var employees = Repository.LoadEmployees();
    var result = employees.ToLookup(x => x.Name);
    foreach (var item in result)
    {
        item.Print($"Employee in '{item.Key}' Name");
    }
}
#endregion