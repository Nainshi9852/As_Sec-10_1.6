using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class Class
    {
        public string ClassName { get; set; }
        public int ClassCode { get; set; }
        public Teacher AssignedTeacher { get; set; }
        public Subject MainSubject { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Class Name: {ClassName}");
            Console.WriteLine($"Class Code: {ClassCode}");
            Console.WriteLine("Assigned Teacher:");
            AssignedTeacher.DisplayInfo();
            Console.WriteLine("Main Subject:");
            MainSubject.DisplayInfo();
        }
    }
}
