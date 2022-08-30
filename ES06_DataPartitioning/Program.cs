using ES06_DataPartitioning;
using LINQTut_Shared.Repository;
using static LINQTut_Shared.Repository.ExtensionFunctional;

var Empls = Repository.LoadEmployees();

#region Skip

Print_Space.Space(" Skip Ex 01 ");

#region   LINQ_Skip_Ex01


var SkEm01 = Empls.Skip(10);
SkEm01.Print("Skip First 10 Emps (Methods Syntax)");

var SkEm02 = Empls.SkipWhile(x => x.Salary >= 200_000);
SkEm02.Print("Skip While Salary Greater than or Equals 200_000");

var SkEm03 = Empls.SkipLast(10);
SkEm03.Print("Skip Last 10 Emps (Methods Syntax)");

#endregion



#endregion

#region Take

Print_Space.Space(" Take Ex 01 ");

#region   LINQ_Take_Ex01


var TakeEm01 = Empls.Skip(10).Take(10);
TakeEm01.Print("Take First 10 Emps (Methods Syntax)");

var TakeEm02 = Empls.TakeWhile(x => x.Salary <= 200_000);
TakeEm02.Print("Take While Salary Smaller than or Equals 200_000");

var TakeEm03 = Empls.TakeLast(10);
TakeEm03.Print("Take Last 10 Emps (Methods Syntax)");

#endregion



#endregion

#region chunck

Print_Space.Space(" chunck Ex 01 ");

#region   LINQ_chunck_Ex01


var Chunks = Empls.Chunk(10).ToList();

for (int i = 0; i < Chunks.Count; i++)
{
    Chunks[i].Print($"Chunks #{i + 1}");
}

#endregion



#endregion

#region Paginate

Print_Space.Space(" Paginate Ex 01 ");
var ALLEmps = Repository.LoadEmployees();
var page = 1;
var size = 10;

Console.WriteLine("result per page:");
if (int.TryParse(Console.ReadLine(), out int resultPerPage))
{
    size = resultPerPage;
}
Console.WriteLine("page No.:");
if (int.TryParse(Console.ReadLine(), out int pageNo))
{
    page = pageNo;
}



var result = ALLEmps.Paginate(page, size);

var resultCount = result.Count();

var startRecord = ((page - 1) * size) + 1;

var endRecord =
     resultCount < size
    ? startRecord + resultCount - 1
    : size * (page - 1) + size;

result.Print($"showing employees {startRecord} - {endRecord}");
#endregion


Console.ReadKey();
