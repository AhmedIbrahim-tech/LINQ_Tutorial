
using ES10_GenerationOperations.Models;
using ES10_GenerationOperations.Repository;



#region Concat()



var q1 = QuestionBank.Randomize(3);
var q2 = QuestionBank.Randomize(2);

var conQuiz = q1.Concat(q2);

conQuiz.ToQuiz();


#endregion


#region Concat() and extract



var q3 = QuestionBank.Randomize(3);
var q4 = QuestionBank.Randomize(2);

var QuestionsTitle = q1.Select(T => T.Title).Concat(q2.Select(Q => Q.Title));

foreach (var title in QuestionsTitle)
{
    Console.WriteLine("Titles of Questions" + title);
}


#endregion


#region Concat() multiple sequences



var q5 = QuestionBank.Randomize(3);
var q6 = QuestionBank.Randomize(2);
var Q7 = QuestionBank.GetQuestionRange(Enumerable.Range(11, 14));

var MultiQuestionsTitle = q1.Select(T => T.Title).Concat(q2.Select(Q => Q.Title)).Concat(Q7.Select(a => a.Title));

foreach (var title in QuestionsTitle)
{
    Console.WriteLine("Titles of Questions" + title);
}


#endregion


#region Concatenation using instantiation

Console.WriteLine("-----------------------------Concatenation using instantiation-----------------------------");

var q01 = QuestionBank.Randomize(3);
var q02 = QuestionBank.Randomize(2);

var MultiQuestionTitle = new[] { q01, q02 }.SelectMany(x=>x);

MultiQuestionTitle.ToQuiz();


#endregion

Console.ReadKey();