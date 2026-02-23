using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class MustSubject:Must
    {
        public int subjectCode { get; set; }
        public int minHours { get; set; }
        public int maxHours { get; set; }
        public int sumHours { get; set; }

        public override bool ifMust(Shibuz s)
        {
            return true;
            if (s == null||s.subjectId!=subjectCode)
                return true;
            int r2 = 0;
            int rezef = 0;

            if(Sceduel.hoursSubject[subjectCode]+1<=sumHours)
           
                {
                    for(int i=0;i<Sceduel.scedular[s.day].Count()&& Sceduel.scedular[s.day][i].hour < s.hour; i++)
                {
                    if (Sceduel.scedular[s.day][i].subjectId == subjectCode)
                    {
                        rezef++;
                    }
                    else rezef = 0;
                }
                for (int i = Sceduel.scedular[s.day].Count(); i > 0 && Sceduel.scedular[s.day][i].hour >s.hour; i--)
                {
                    if (Sceduel.scedular[s.day][i].subjectId == subjectCode)
                    {
                       r2++;
                    }
                    else r2 = 0;
                }
                if (r2 + rezef + 1 < maxHours)
                    return true;


            }    
           //foreach(var item in Sceduel.scedular)
           // {
           //     foreach(var i in item.Value)
           //     {
           //         if (i.subjectId != subjectCode)
           //             if(rezef>0&&rezef<minHours)
           //            retur
           //         if()
           //     }
           // }
            
           // if(s.subjectId==subjectCode&&)
      
        }
    }
}
