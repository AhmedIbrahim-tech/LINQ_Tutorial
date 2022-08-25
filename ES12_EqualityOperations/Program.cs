
using ES10_GenerationOperations.Models;
using ES10_GenerationOperations.Repository;



#region SequenceEqual()

#region Exampel 01

var q1 = QuestionBank.PickOne();
var q2 = QuestionBank.PickOne();
var q3 = QuestionBank.PickOne();

var quiz1 = new List<Question>() { q1, q2, q3 };
var quiz2 = new List<Question>() { q1, q2, q3 };

var SequenceEqual = quiz1.SequenceEqual(quiz2);

Console.WriteLine($"Quiz 01 and Quiz 02 {(SequenceEqual ? "Are" : "Are Not")} Equal");


#endregion

#region Exampel 02

var randomQues = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));

var quiz01 = randomQues;
var quiz02 = randomQues;

var SeqEqual = quiz01.SequenceEqual(quiz02);

Console.WriteLine($"Quiz 01 and Quiz 02 {(SeqEqual ? "Are" : "Are Not")} Equal");


#endregion

#region Exampel 03


var quiz03 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4)); ;
var quiz04 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4)); ;

var SeqEqual01 = quiz03.SequenceEqual(quiz04);

Console.WriteLine($"Quiz 01 and Quiz 02 {(SeqEqual01 ? "Are" : "Are Not")} Equal");

/*
 *  In This's Example The Result Are Different from Anthor Examples Because we haven't called her before.
*/
#endregion

#endregion




Console.ReadKey();