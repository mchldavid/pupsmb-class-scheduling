using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSchedulingComputerAided
{
    public class PrintData
    {
        public string subjects_id { get; set; }
        public string course { get; set; }
        public string yearLevel { get; set; }
        public string subjectCode { get; set; }
        public string subjectDescription { get; set; }
        public string lectureHours { get; set; }
        public string laboratoryHours { get; set; }
        public string units { get; set; }

        string sql = "SELECT subjects_id, course, yearLevel, subjectCode , subjectDescription , lectureHours , laboratoryHours , units FROM tbl_subjects t WHERE curriculums_id = @id AND semester = @sem;";

    }
}
