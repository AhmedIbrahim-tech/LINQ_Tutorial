using LINQTut_Shared.Repository;
using static LINQTut_Shared.Repository.ExtensionFunctional;

#region Distinct


// MeetingRepo.Meetings.PrintMeeting("All Mettings");

var M1and2 = MeetingRepo.Meeting1.Participants.Concat(MeetingRepo.Meeting2.Participants);
M1and2.Print("Participants in M1 & M2");

var DisM3 = M1and2.Distinct();
DisM3.Print("Distinct Participants in M1 & M2");


var DisM4 = M1and2.DistinctBy(x => x.EmployeeNo);
DisM4.Print("Distinct By Participants in M1 & M2");


#endregion

#region Except
var set01 = MeetingRepo.Meeting1.Participants;
var set02 = MeetingRepo.Meeting2.Participants;

set01.Print("set01 Participants M1 & M2");
set02.Print("set02 Participants M1 & M2");

var Except = set01.Except(set02);
Except.Print("Except Participants M1 & M2");

var ExceptBy = set01.ExceptBy(set02.Select(x=>x.EmployeeNo) , x=>x.EmployeeNo);
ExceptBy.Print("Except By Participants M1 & M2");

#endregion


#region Intersect



var Intersect = set01.Intersect(set02);
Intersect.Print("Intersect  Participants M1 & M2");

var Intersectby = set01.IntersectBy(set02.Select(x => x.EmployeeNo), x => x.EmployeeNo);
Intersectby.Print("Intersect  By Participants M1 & M2");

#endregion


#region Union



var Union = set01.Union(set02);
Union.Print("UnionBy  Participants M1 & M2");

var UnionBy = set01.UnionBy(set02 , x => x.EmployeeNo);
UnionBy.Print("UnionBy  By Participants M1 & M2");

#endregion

Console.ReadKey();