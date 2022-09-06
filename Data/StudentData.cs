using SayItWebsiteNet5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayItWebsiteNet5.Data
{
    public class StudentData
    {
        public StudentData()
        {

        }
        public StudentData(Student stud)
        {
            Stud = stud;
        }
        public Student Stud { get; set; }
        public StudentDailyData Monday { get; set; }
        public StudentDailyData Tuesday { get; set; }
        public StudentDailyData Thursday { get; set; }
        public StudentDailyData Friday { get; set; }
    }
}
