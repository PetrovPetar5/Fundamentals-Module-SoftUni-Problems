namespace OrderByAge
{
    public class Person
    {
        public Person(string name, string iD, int age)
        {
            this.Name = name;
            this.ID = iD;
            this.Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            var result = $"{this.Name} with ID: {this.ID} is {this.Age} years old.";

            return result;
        }
    }
}
