using ES05_SortingData_OrderBy.ComparerBy;
using LINQTut_Shared.Repository;
using static LINQTut_Shared.Repository.ExtensionFunctional;


#region Order By 

Print_Space.Space(" Order By ASC Ex 01 ");

#region   LINQ_OrderBy_Ex01 ASC

string[] Fruits = { "Apple", "Banana", "Perpre", "Mango", "Grape" };

var OrderFruites = Fruits.OrderBy(f => f);
OrderFruites.Print("Fruites ASC (Methods Syntax)");

var OrderFruitsByQuery = from f in Fruits orderby f select f;
OrderFruitsByQuery.Print("Fruites ASC (Query Syntax)");


#endregion

Print_Space.Space(" Order By DESC Ex 02 ");

#region   LINQ_OrderBy_Ex02 DESC


var OrderFruitesDESC = Fruits.OrderByDescending(f => f);
OrderFruites.Print("Fruites DESC (Methods Syntax )");

var OrderFruitsByQueryDESC = from f in Fruits orderby f descending select f;
OrderFruitsByQueryDESC.Print("Fruites DESC (Query Syntax)");



#endregion

Print_Space.Space(" Order By Length Ex 03 ");

#region   LINQ_OrderBy_Ex03 Length


var OrderFruitesLength = Fruits.OrderBy(f => f.Length);
OrderFruites.Print("Fruites Length (Methods Syntax )");

var OrderFruitsByQueryLength = from f in Fruits orderby f.Length descending select f;
OrderFruitsByQueryDESC.Print("Fruites Length (Query Syntax)");



#endregion



#endregion

#region Then By

Print_Space.Space(" Then By Ex 01 ");

#region   LINQ_OrderBy_Ex01  ASC

var emps = Repository.LoadEmployees();

var sortedEmps = emps.OrderBy(f => f.Name).ThenBy(s => s.Salary);
sortedEmps.Print("Sorted Emps by Name Then Salary");


#endregion

#endregion

#region Comparer By

Print_Space.Space(" Comparer By Ex 01 ");

#region   LINQ_ComparerBy_Ex01  ASC

var Compareremps = Repository.LoadEmployees();

var Compareremployees = Compareremps.OrderBy(n => n, new EmployeeComparer());
Compareremployees.Print(" Order By with Comparer By Ex 01");


#endregion

#endregion

#region Reverse

Print_Space.Space(" Comparer By Ex 01 ");

#region   LINQ_ComparerBy_Ex01  ASC

var Reverseemps = Repository.LoadEmployees();

Reverseemps.Reverse();
Reverseemps.Print(" Reverse Ex 01");



#endregion

#endregion


Console.ReadKey();