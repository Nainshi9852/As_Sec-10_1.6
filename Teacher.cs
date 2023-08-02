using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Specialization { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Teacher: {Name}");
            Console.WriteLine($"Specialization: {Specialization}");
        }
    }
}
