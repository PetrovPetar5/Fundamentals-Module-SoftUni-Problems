namespace Students
{
    public class Student
    {
        public Student(string firstName, string secondName, double grade)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Grade = grade;
        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            var result = $"{this.FirstName} {this.SecondName}: {this.Grade:F2}";

            return result;
        }
    }
}
