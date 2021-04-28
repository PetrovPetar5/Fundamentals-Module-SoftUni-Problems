namespace StudentAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            uint numberOfPairsToReceive = uint.Parse(Console.ReadLine());
            var studentsGrades = new Dictionary<string, List<double>>();
            for (int i = 0; i < numberOfPairsToReceive; i++)
            {
                string curStudentName = Console.ReadLine();
                double curStudentGrade = double.Parse(Console.ReadLine());
                if (!studentsGrades.ContainsKey(curStudentName))
                {
                    studentsGrades.Add(curStudentName, new List<double>());
                }

                studentsGrades[curStudentName].Add(curStudentGrade);
            }

            var studentsAverageGrades = new Dictionary<string, double>();
            foreach (var kvp in studentsGrades)
            {
                double averageGrade = kvp.Value.Average();
                if (!(averageGrade < 4.5))
                {
                    studentsAverageGrades.Add(kvp.Key, averageGrade);
                }
            }

            studentsAverageGrades = studentsAverageGrades
                .OrderByDescending(grade => grade.Value)
                .ToDictionary(a => a.Key, b => b.Value);
            
            foreach (var kvp in studentsAverageGrades)
            {
                Console.WriteLine($"{ kvp.Key} -> { kvp.Value:F2}");
            }
        }
    }
}
