using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSchedulingComputerAided
{
    public class SubjectForStudents
    {
        public static string[] course = new string[30];

        public static string[] CourseCode
        {
            get;
            set;
        }

        public static string[] SubjectDescription
        {
            get;
            set;
        }
        public static string[] Units
        {
            get;
            set;
        }

        public static string[] LecHrs
        {
            get;
            set;
        }

        public static string[] LabHrs
        {
            get;
            set;
        }
    }
}
