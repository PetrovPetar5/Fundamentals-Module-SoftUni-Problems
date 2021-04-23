namespace StudentsLab
{
    public class Student
    {
        public Student(string firstName, string lastName, int age, string hometown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Hometown = hometown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }

        public override string ToString()
        {
            var result = $"{this.FirstName} {this.LastName} is {this.Age} years old.";

            return result;
        }
    }
}
