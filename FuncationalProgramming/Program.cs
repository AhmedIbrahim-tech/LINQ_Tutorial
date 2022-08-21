using FuncationalProgramming;

/*---------------------------------------------------------------------------------------------------*/



RunExtnensionFunctional_Two();


Console.ReadKey();

/*---------------------------------------------------------------------------------------------------*/


static void RunExtensionProcedural()
{
    var q1 = ExtnensionProcedural.GetEmployeesWithFirstNameStartWith("M");
    ExtnensionProcedural.Print(q1, "Get Employees With First Name Start With [M]");


    var q2 = ExtnensionProcedural.GetEmployeesWithFirstNameEndWith("ra");
    ExtnensionProcedural.Print(q2, "Get Employees With First Name End With [ra]");
}



static void RunExtnensionFunctional_One()
{
    var List = Repository.LoadEmployee();
    var q1 = ExtnensionFunctional_One.Filter(List, e => e.Frist_Name.ToLowerInvariant().StartsWith("m"));
    ExtnensionFunctional_One.Print(q1, "Get Employees With First Name Start With [M]");

    var q2 = ExtnensionFunctional_One.Filter(List, e => e.Last_Name.ToLowerInvariant().StartsWith("e") && e.Salary > 4000);
    ExtnensionFunctional_One.Print(q2, "Get Employees With Last Name Start With [E] && Salary Grater than 4000");

}



static void RunExtnensionFunctional_Two()
{
    var List = Repository.LoadEmployee();
    var q1 = List.Filter(e => e.Frist_Name.ToLowerInvariant().StartsWith("m"));
    q1.Print("Get Employees With First Name Start With [M]");

    var q2 = List.Filter(e => e.Last_Name.ToLowerInvariant().StartsWith("e") && e.Salary > 4000);
    q2.Print("Get Employees With Last Name Start With [E] && Salary Grater than 4000");

}