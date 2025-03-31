using System;

namespace Records
{
    public record Person(string FirstName, string LastName, int Age);

    public class PersonRecordExample
    {
        public static void Run()
        {
            var p1 = new Person("Mehmet", "Yurttaş", 30);
            var p2 = p1 with { FirstName = "Ahmet" };

            Console.WriteLine($"Orijinal: {p1}");
            Console.WriteLine($"Kopya    : {p2}");
        }
    }
}
