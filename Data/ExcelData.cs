using SayItWebsiteNet5.Models;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace SayItWebsiteNet5.Data
{
    public class ExcelData
    {

        public ExcelData(int weeknum, List<Protocol> protocols)
        {
            WeekNumber = weeknum;

            foreach (Protocol p in protocols)
            {
                switch (p.Date.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        Monday = p;

                        break;
                    case DayOfWeek.Tuesday:
                        Tuesday = p;

                        break;
                    case DayOfWeek.Thursday:
                        Thursday = p;

                        break;
                    case DayOfWeek.Friday:
                        Friday = p;

                        break;
                }
            }
            protLi.Add(Monday);
            protLi.Add(Tuesday);
            protLi.Add(Thursday);
            protLi.Add(Friday);


            if (Monday != null)
            {
                foreach (KeyValuePair<string, ProtocolData> item in this.Monday.StudentProtocol)
                {

                    StudentData x = new StudentData(item.Value.StudentData);

                    studData2.Add(x);
                }
            }

            foreach (var x in studData2)
            {
                FillDays(protLi, x);

            }


        }

        public static void FillDays(List<Protocol> prot, StudentData x)
        {
            foreach (Protocol p in prot)
            {
                if (p != null)
                {
                    switch (p.Date.DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                            x.Monday = new StudentDailyData(p.StudentProtocol[x.Stud._Id.ToString()].Present, p.StudentProtocol[x.Stud._Id.ToString()].Note);
                            break;

                        case DayOfWeek.Tuesday:
                            x.Tuesday = new StudentDailyData(p.StudentProtocol[x.Stud._Id.ToString()].Present, p.StudentProtocol[x.Stud._Id.ToString()].Note);
                            break;
                        case DayOfWeek.Thursday:
                            x.Thursday = new StudentDailyData(p.StudentProtocol[x.Stud._Id.ToString()].Present, p.StudentProtocol[x.Stud._Id.ToString()].Note);
                            break;
                        case DayOfWeek.Friday:
                            x.Friday = new StudentDailyData(p.StudentProtocol[x.Stud._Id.ToString()].Present, p.StudentProtocol[x.Stud._Id.ToString()].Note);
                            break;

                    }
                }
            }

        }

        public int WeekNumber { get; set; }

        public List<StudentData> studData2 = new List<StudentData>();
        public List<Protocol> protLi = new List<Protocol>();
        public Protocol Monday { get; set; } // non-default getter med private fields -> bool fravær + string note 
        public Protocol Tuesday { get; set; }
        public Protocol Thursday { get; set; }
        public Protocol Friday { get; set; }



    }


}
