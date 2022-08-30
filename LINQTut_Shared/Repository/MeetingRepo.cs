using LINQTut_Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTut_Shared.Repository
{
    public class MeetingRepo
    {
        public static Meeting Meeting1 => new Meeting
        {
            Title = "Meeting - 1",
            Date = new DateOnly(2022, 03, 02),
            StartAt = new TimeOnly(08, 0, 0),
            EndAt = new TimeOnly(09, 0, 0),
            Participants = {
                new Emp_Meeting { EmployeeNo = "a10", Name = "Ruba Ali" },
                new Emp_Meeting { EmployeeNo = "a11", Name = "Sana Sayed" },
                new Emp_Meeting { EmployeeNo = "a12", Name = "Abeer Omar" },

             }
        };

        public static Meeting Meeting2 => new Meeting
        {
            Title = "Meeting - 2",
            Date = new DateOnly(2022, 03, 02),
            StartAt = new TimeOnly(09, 0, 0),
            EndAt = new TimeOnly(10, 0, 0),
            Participants = {
                new Emp_Meeting { EmployeeNo = "a11", Name = "Sana Sayed" },
                new Emp_Meeting { EmployeeNo = "a13", Name = "Rashed Sameh" },
                new Emp_Meeting { EmployeeNo = "a15", Name = "Omniya Sayed" },
             }
        };

        public static Meeting Meeting3 => new Meeting
        {
            Title = "Meeting - 3",
            Date = new DateOnly(2022, 03, 02),
            StartAt = new TimeOnly(10, 0, 0),
            EndAt = new TimeOnly(11, 0, 0),
            Participants = {
                new Emp_Meeting { EmployeeNo = "a17", Name = "Peter Siri" },
                new Emp_Meeting { EmployeeNo = "a18", Name = "Joe Harb" }
            }
        };



        public static Meeting Meeting4 => new Meeting
        {
            Title = "Meeting - 7",
            Date = new DateOnly(2022, 03, 03),
            StartAt = new TimeOnly(10, 0, 0),
            EndAt = new TimeOnly(11, 0, 0),
            Participants = {
                 new Emp_Meeting { EmployeeNo = "a14", Name = "Salah Sayed" },
                 new Emp_Meeting { EmployeeNo = "a15", Name = "Omniya Sayed" },
                 new Emp_Meeting { EmployeeNo = "a17", Name = "Peter Siri" }
            }
        };

        public static List<Emp_Meeting> Emp_Meetings => new List<Emp_Meeting> {
            new Emp_Meeting { EmployeeNo = "a10", Name = "Ruba Ali" },
            new Emp_Meeting { EmployeeNo = "a11", Name = "Sana Sayed" },
            new Emp_Meeting { EmployeeNo = "a12", Name = "Abeer Omar" },
            new Emp_Meeting { EmployeeNo = "a13", Name = "Rashed Sameh" },
            new Emp_Meeting { EmployeeNo = "a14", Name = "Salah Sayed" },
            new Emp_Meeting { EmployeeNo = "a15", Name = "Omniya Sayed" },
            new Emp_Meeting { EmployeeNo = "a16", Name = "Rana Siri" },
            new Emp_Meeting { EmployeeNo = "a17", Name = "Peter Siri" },
            new Emp_Meeting { EmployeeNo = "a18", Name = "Joe Harb" },
            new Emp_Meeting { EmployeeNo = "a19", Name = "Sara Madi" },
            new Emp_Meeting { EmployeeNo = "a20", Name = "Ismail Saleh" },
            new Emp_Meeting { EmployeeNo = "a21", Name = "Rama Ali" },
            new Emp_Meeting { EmployeeNo = "a22", Name = "Sana Sayed" }
        };

        public static List<Meeting> Meetings => new List<Meeting> {
            Meeting1, Meeting2, Meeting3, Meeting4
        };
    }
}
