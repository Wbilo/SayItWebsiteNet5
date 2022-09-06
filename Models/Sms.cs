using System.Collections.Generic;

namespace SayItWebsiteNet5.Models
{
    public class Sms
    {
        public string Message { get; set; }
        public List<Student> Receivers { get; set; }

    }
}
