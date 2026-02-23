using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MustTeachers : Must
    {
   

        
        public string teacherCode { get; set; }
        public int day { get; set; }
        public override bool ifMust(Shibuz s)
        {
          ;
            if (s == null)

                return true;
            if (s.day == day && s.teacherCode == teacherCode)
                return false;
            return true;
        }
    }
}
