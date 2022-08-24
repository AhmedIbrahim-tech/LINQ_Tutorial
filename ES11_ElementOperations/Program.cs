using ES10_GenerationOperations.Repository;


#region ElementAt

Console.WriteLine("\n----------------------------------------Get Element At Question-------------------------------------------\n");

var Q01 = QuestionBank.All;

var QuesAt10 = Q01.ElementAt(10);

Console.WriteLine($"Question No 10 \n {QuesAt10}");


// var QuesAt300 = Q01.ElementAt(300);

var QuesAt300 = Q01.ElementAtOrDefault(300);

Console.WriteLine($"\n Question No 300 \n {QuesAt300}");

#endregion


#region First


Console.WriteLine("\n----------------------------------------Get First Question-------------------------------------------\n");

var FirstQues = QuestionBank.All;

var GetFirstQues = FirstQues.First();

Console.WriteLine($"Get First Question \n {GetFirstQues}");


Console.WriteLine("\n----------Get First Or Default Question---------\n");

var GetSomeFirstORDefalutQues = FirstQues.FirstOrDefault(x => x.Title.Length == 0);

Console.WriteLine($"Get First Or Default Question \n {GetSomeFirstORDefalutQues}");

if (GetSomeFirstORDefalutQues is null)
    Console.WriteLine("Question is null");


#endregion


#region Last


Console.WriteLine("\n----------------------------------------Get Last Question-------------------------------------------\n");

var LastQues = QuestionBank.All;

var GetLastQues = LastQues.Last();

Console.WriteLine($"Get Last Question \n {GetLastQues}");


Console.WriteLine("\n----------Get Last Or Default Question---------\n");

var GetSomeLastORDefalutQues = LastQues.LastOrDefault(x => x.Title.Length == 0);

Console.WriteLine($"Get Last Or Default Question \n {GetSomeLastORDefalutQues}");

if (GetSomeLastORDefalutQues is null)
    Console.WriteLine("Question is null");


#endregion

#region Single


Console.WriteLine("\n----------------------------------------Get Single Question-------------------------------------------\n");

var SingleQues = QuestionBank.All;

var GetSingleQues = SingleQues.Single(x => x.Title.Contains("#245"));

// Console.WriteLine($"Get Single Question \n {GetSingleQues}");


Console.WriteLine("\n----------Get Single Or Default Question---------\n");

var GetSomeSingleORDefalutQues = SingleQues.SingleOrDefault(x => x.Title.Contains("#245"));

Console.WriteLine($"Get Single Or Default Question \n {GetSomeSingleORDefalutQues}");

if (GetSomeSingleORDefalutQues is null)
    Console.WriteLine("Question is null");


#endregion

Console.ReadKey();