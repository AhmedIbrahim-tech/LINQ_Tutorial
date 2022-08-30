



#region Join_Operation




using LINQTut_Shared.Repository;

static void RunJoin()
{
    var employees = Repository.LoadEmployees();
    var departments = Repository.LoadDepartment();

    var joinEmps = employees.Join(
        departments,
        emps => Convert.ToInt32(emps.EmployeeNo),
        deps => deps.Id,
        (emps, deps) => new JoinofEmplyees
        { EmployeeFullName = emps.Name, DepartmentFullName = deps.Name });

    foreach (var item in joinEmps)
        Console.WriteLine($"{item.EmployeeFullName} [{item.DepartmentFullName}]");

}


#endregion