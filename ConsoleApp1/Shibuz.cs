using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class Shibuz
    {
        public int subjectId { get; set; }
        public int day { get; set; }
        public int hour { get; set; }
        public string teacherName
        {
            get
            {
                return teacherName;
            }
            set
            {
                teacherName = value;

                teacherCode = (from t in School.teachers
                               where t.name == value
                               select t.id).ToList()[0];
            }
        }
        public string teacherCode { get; set; }
        public int classCode { get; set; }
    }
}
