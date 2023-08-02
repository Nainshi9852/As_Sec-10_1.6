using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class Subject
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Subject: {Name}");
            Console.WriteLine($"Code: {Code}");
        }
    }
}
