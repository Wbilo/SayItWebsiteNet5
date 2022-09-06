using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayItWebsiteNet5.Data
{
    public class StudentDailyData
    {
        public StudentDailyData(bool p, string n)
        {
            Present = p;
            Note = n;
        }
        public bool Present { get; set; }
        public string Note { get; set; }
    }
}
