namespace AdvertisementMessage
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var phrases = new string[] {    "Excellent product.", "Such a great product.",
                                            "I always use that product.", "Best product of its category.",
                                            "Exceptional product.", "I can’t live without this product."};

            var events = new string[] {     "Now I feel good.", "I have succeeded with this product.",
                                            "Makes miracles. I am happy of the results!",
                                             "I cannot believe but now I feel awesome.",
                                            "Try it yourself, I am very satisfied.", "I feel great!"};

            var authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            var cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            var messagesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < messagesCount; i++)
            {
                var rand = new Random();
                var randPhrase = rand.Next(0, phrases.Length);
                var randEvent = rand.Next(0, events.Length);
                var randAuthor = rand.Next(0, authors.Length);
                var randCity = rand.Next(0, cities.Length);
                Console.WriteLine($"{phrases[randPhrase]} {events[randEvent]} {authors[randAuthor]} – {cities[randCity]}");
            }
        }
    }
}
