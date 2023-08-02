using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "John Doe",
                Age = 16,
                Grade = "10th"
            };

            Subject subject = new Subject
            {
                Name = "Math",
                Code = 101
            };

            Teacher teacher = new Teacher
            {
                Name = "Jane Smith",
                Specialization = "Mathematics"
            };

            Class myClass = new Class
            {
                ClassName = "Class A",
                ClassCode = 123,
                AssignedTeacher = teacher,
                MainSubject = subject
            };

            Console.WriteLine("Student Information:");
            student.DisplayInfo();

            Console.WriteLine("\nSubject Information:");
            subject.DisplayInfo();

            Console.WriteLine("\nTeacher Information:");
            teacher.DisplayInfo();

            Console.WriteLine("\nClass Information:");
            myClass.DisplayInfo();

            Console.ReadKey();
        }
    }
}
