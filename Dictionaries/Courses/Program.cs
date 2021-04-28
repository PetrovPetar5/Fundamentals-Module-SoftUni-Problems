namespace Courses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var courseStudentsNames = new Dictionary<string, List<string>>();
            string command = String.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] curCommand = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string courseName = curCommand[0];
                string studentName = curCommand[1];
                if (!courseStudentsNames.ContainsKey(courseName))
                {
                    courseStudentsNames[courseName] = new List<string>();
                }

                courseStudentsNames[courseName].Add(studentName);
            }

            var coursesOrderedByStudentsCount = courseStudentsNames
                .OrderByDescending(x => x.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in coursesOrderedByStudentsCount)
            {
                string curCourseName = kvp.Key;
                Console.WriteLine($"{curCourseName.Trim()}: {kvp.Value.Count}");
                foreach (var studentName in kvp.Value)
                {
                    Console.WriteLine($"--{studentName}");
                }
            }
        }
    }
}

