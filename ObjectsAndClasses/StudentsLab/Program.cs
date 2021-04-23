namespace StudentsLab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var endCommand = "end";
            var curCommand = String.Empty;
            var students = new List<Student>();
            while ((curCommand = Console.ReadLine()) != endCommand)
            {
                var studentArgs = curCommand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var firstName = studentArgs[0];
                var lastName = studentArgs[1];
                var age = int.Parse(studentArgs[2]);
                var hometown = studentArgs[3];
                var curStudent = new Student(firstName, lastName, age, hometown);
                if (IsUnique(firstName, lastName, students))
                {
                    students.Add(curStudent);
                }
                else
                {
                    var student = students.First(x => x.FirstName == firstName && x.LastName == lastName);
                    student.Age = age;
                    student.Hometown = hometown;
                }
            }

            var cityName = Console.ReadLine();
            var studentsInThatCity = students.Where(x => x.Hometown == cityName).ToList();
            Console.WriteLine(String.Join(Environment.NewLine, studentsInThatCity));
        }

        private static bool IsUnique(string firstName, string lastName, List<Student> students)
        {
            if (students.Any(x => x.FirstName == firstName) && students.Any(x => x.LastName == lastName))
            {
                return false;
            }

            return true;
        }
    }
}
