using LINQTut_Shared.Repository;

var employees = Repository.LoadEmployees();
var departments = Repository.LoadDepartment();


//RunJoin();

//RunJoinQuerySyntax();

//RunGroupJoin();

//RunGroupJoinQuerySyntax();


Console.ReadKey();


#region Join_Operation




//void RunJoin()
//{
//    var joinEmps = employees.Join(departments, 
//        emps => emps.EmployeeNo, 
//        deps => deps.Id, 
//        (emps, deps) => new JoinofEmplyees { EmployeeFullName = emps.Name, DepartmentFullName = deps.Id });
//}


#endregion