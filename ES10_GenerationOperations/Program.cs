using ES10_GenerationOperations.Models;
using ES10_GenerationOperations.Repository;

#region Empty List

var questions = new List<Question>(); // Empty List 


foreach (var item in questions)
{
    Console.WriteLine("Questions is :" + item);
}


var questions2 = Enumerable.Empty<Question>(); // Empty List 


foreach (var item in questions2)
{
    Console.WriteLine("Questions is :" + item);
}

#endregion


#region Default Empty List

//Console.WriteLine($"default(int)        {default(int)}");
//Console.WriteLine("default(DateTime) " + default(DateTime));
//Console.WriteLine("default(Object)   " + default(Object) is null ? "NULL" : default(Object) is null);


var Default_questions = Enumerable.Empty<Question>(); // Empty List 

var DefQues = Default_questions.DefaultIfEmpty();

var DefQues2 = Default_questions.DefaultIfEmpty(Question.Default);

// DefQues2.ToQuiz();

foreach (var item in Default_questions)
{
    Console.WriteLine("Default Questions is :" + item);
}
#endregion


#region Range

// New Way of Range to print from 1 to 10
var Range_questions = Enumerable.Range(0, 10);

//foreach (var item in Range_questions)
//{

//    Console.WriteLine($"{item}");
//}


var RangeQ = QuestionBank.GetQuestionRange(Range_questions);

RangeQ.ToQuiz();


#region Old Way to print Range from 1 to 10
// Old Way to print Range from 1 to 10

//int[] OLdRange = new int[10];

//for (int i = 0; i < OLdRange.Length; i++)
//{ OLdRange[i] = i; }

//for (int i = 0; i < OLdRange.Length; i++)
//    Console.WriteLine($"{i}");
#endregion


#endregion


#region Repeat


Console.WriteLine("\n----------------------- Repeat -----------------------------------\n");
                            
var RQ01 = QuestionBank.PickOne();

var ReepeatQuestion = Enumerable.Repeat(RQ01, 5);

ReepeatQuestion.ToQuiz();

#endregion


Console.WriteLine("\n-----------------------Randomize-----------------------------------\n");

var asd = QuestionBank.Randomize(5);
asd.ToQuiz();

Console.ReadKey();