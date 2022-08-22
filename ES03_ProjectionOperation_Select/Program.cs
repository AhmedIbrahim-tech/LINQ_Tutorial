using ES03_ProjectionOperation_Select;
using FuncationalProgramming;

#region Select 

Demo.Print("Ex 01");

#region   LINQ_Select_Ex01 With String

List<string> Words = new() { "i", "love", "asp.net", "core" };

var Result = Words.Select(x => x.ToUpper());

var Result_byAnthorWay = from word in Words select word.ToUpper();

foreach (var item in Result_byAnthorWay)
{
    Console.WriteLine(item);

}

#endregion


Demo.Print("Ex 02");

#region   LINQ_Select_Ex02 With Number

List<int> Numbers = new() { 2, 4, 6, 8, 10 };

var NumResult = Numbers.Select(x => x * x);

var NumResult_byAnthorWay = from Number in Numbers select Number * Number;

foreach (var item in NumResult)
{
    Console.WriteLine(item);

}

#endregion 

Demo.Print("Ex 03");

#region   LINQ_Select_Ex03 Foreach on Employee

var EmployeeDto = Repository.LoadEmployee();

var ResultofEmployee = EmployeeDto.Select(x =>
{
    return new EmployeeDTO
    {
        Name = $"{x.Frist_Name} {x.Last_Name}",
        Salary = x.Salary
    };
});


foreach (var item in ResultofEmployee)
{
    // Console.WriteLine($"{item.Name} , [{item.Salary}]");
    Console.WriteLine(item);
}

#endregion


#endregion


#region Select Many

Demo.Print("Select Many Ex 01");

#region   LINQ_SelectMany_Ex01

string[] Sentences = { "I Love Asp.Net Core And angular" };

var ResultSelectMany = Sentences.SelectMany(x => x.Split(" "));

foreach (var item in ResultSelectMany)
{

    Console.WriteLine(item);
}

#endregion

#endregion


#region ZIP

Demo.Print("Zip Ex 01");

#region   LINQ_ZIP_Ex01

string[] colorName = { "Red", "Green", "Blue", "Black" };
string[] colorHEX = { "FF0000", "00FF00", "0000FF", "extra" , "ffffff" };

var colors = colorName.Zip(colorHEX, (name, hex) => $"{name} => {hex}");

foreach (var item in colors)
{

    Console.WriteLine(item);
}

#endregion



Demo.Print("Zip Ex 02");

#region   LINQ_ZIP_Ex02

var ZipEmployees = Repository.LoadEmployee().ToArray();

var GetFirstThreeEmp = ZipEmployees[..3];
var GetLastThreeEmp = ZipEmployees[^3..];
var Teams = GetFirstThreeEmp.Zip(GetLastThreeEmp, (first, second) => $"{first.Frist_Name} {first.Last_Name} => {second.Frist_Name} {second.Last_Name}");

foreach (var item in Teams)
{

    Console.WriteLine(item);
}

#endregion


#endregion

Console.ReadKey();

#region Print Space
public class Demo
{
    public static void Print(string title)
    {
        Console.WriteLine();
        Console.WriteLine("┌───────────────────────────────────────────────────────┐");
        Console.WriteLine($"│   {title.PadLeft(25, ' ')}                           │");
        Console.WriteLine("└───────────────────────────────────────────────────────┘");
        Console.WriteLine();
    }
}
#endregion