namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var studentsCount = int.Parse(Console.ReadLine());
            var students = new List<Student>();
            for (int i = 0; i < studentsCount; i++)
            {
                var curStudentArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var firstName = curStudentArgs[0];
                var secondName = curStudentArgs[1];
                var grade = double.Parse(curStudentArgs[2]);

                var curStudent = new Student(firstName, secondName, grade);
                students.Add(curStudent);
            }

            students = students.OrderByDescending(x => x.Grade).ToList();

            Console.WriteLine(String.Join(Environment.NewLine, students));
        }
    }
}
