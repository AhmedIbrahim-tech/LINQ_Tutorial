

#region Aggregate

#region Aggregate() Method with String

using ES10_GenerationOperations.Models;
using ES10_GenerationOperations.Repository;

var names = new[] { "Ahmed", "Ali", "Sayed" };

/*----------------- Old Way -----------------*/
//var output = "";
//foreach (var item in names)
//{
//    output += $"{item},";
//}
//Console.WriteLine($"Names is => [{output.TrimEnd(',')}]");


var outputs = string.Join(" , ", names);

Console.WriteLine($"Names is => [{outputs}]");


var commSparatedNames = names.Aggregate((a, b) => $"{a} , {b}");
Console.WriteLine($"Names With Aggregate is => [{commSparatedNames}]");

#endregion

#region Aggregate() Method with Number

var Numbers = new[] { 1, 2, 3, 4, 5, 6 };

var commSparatedNumbers = Numbers.Aggregate((a, b) => a + b);
Console.WriteLine($"Names With Aggregate is => [{commSparatedNumbers}]");

#endregion

#region Aggregate() Method with Squses

var Quiz = QuestionBank.All;

var LongQueation = Quiz.Aggregate((Longest, Next) => Longest.Title.Length > Next.Title.Length ? Longest : Next);

Console.WriteLine($"Longest Title in Questions is => [{LongQueation}]");


#endregion

#endregion

#region Count

var CountofQuiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));


Console.WriteLine("\n---------------------- Count of Quiz ------------------------");
Console.WriteLine($"Totla of Questions is {CountofQuiz.Count()} ");
Console.WriteLine($"Totla of Questions is {CountofQuiz.Where(x => x.Title.Contains("A")).Count()} ");
Console.WriteLine($"Totla of Questions is {CountofQuiz.Where(x => x.Title.Contains("A")).LongCount  ()} ");
#endregion

#region Max & Min

var MaxQuiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

var ResultMaxQuiz = MaxQuiz.Max(x => x.Title   );

var ResultMaxByQuiz = MaxQuiz.MaxBy(x => x.Title);

var ResultMinByQuiz = MaxQuiz.Min(x => x.Title);

var ResultMinByByQuiz = MaxQuiz.MinBy(x => x.Title);

Console.WriteLine("\n---------------------- Max of Quiz ------------------------");

Console.WriteLine($"Max of Quiz is {ResultMaxQuiz} ");

Console.WriteLine($"Max By of Quiz is {ResultMaxByQuiz} ");

Console.WriteLine($"Min  of Quiz is {ResultMinByQuiz} ");

Console.WriteLine($"Min By  of Quiz is {ResultMinByByQuiz} ");
#endregion

#region Sum

var SumQuiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

var ResultSumQuiz = MaxQuiz.Sum(x => x.Title.Length);


Console.WriteLine("\n---------------------- Sum of Quiz ------------------------");

Console.WriteLine($"Sum of Quiz is : {ResultSumQuiz} ");


#endregion

#region Average

var AverageQuiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

var ResultAverageQuiz = MaxQuiz.Average(x => x.Title.Length);


Console.WriteLine("\n---------------------- Average of Quiz ------------------------");

Console.WriteLine($"Average of Quiz is : {ResultAverageQuiz.ToString("#.##")} ");


#endregion

Console.ReadKey();