namespace Grades
{
    using System;
    class Program
    {
       
        static void Main(string[] args)
        {
            double studentGrade = double.Parse(Console.ReadLine());
            DeterminesWhatAGradeIs(studentGrade);
        }
        static void DeterminesWhatAGradeIs(double studentGrade)
        {
            if (2 <= studentGrade && studentGrade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (3 <= studentGrade && studentGrade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (3.50 <= studentGrade && studentGrade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (4.50 <= studentGrade && studentGrade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (5.50 <= studentGrade && studentGrade <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
