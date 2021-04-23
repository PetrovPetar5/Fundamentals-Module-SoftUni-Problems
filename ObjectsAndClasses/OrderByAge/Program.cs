namespace OrderByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            var curPersonInput = String.Empty;
            var endCommand = "End";
            while ((curPersonInput = Console.ReadLine()) != endCommand)
            {
                var curPersonArgs = curPersonInput.Split();
                var name = curPersonArgs[0];
                var iD = curPersonArgs[1];
                var age = int.Parse(curPersonArgs[2]);

                var curPerson = new Person(name, iD, age);
                people.Add(curPerson);
            }

            var peopleOrderedByAge = people.OrderBy(x => x.Age);
            Console.WriteLine(String.Join(Environment.NewLine, peopleOrderedByAge));
        }
    }
}
