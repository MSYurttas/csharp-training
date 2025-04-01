using System;

namespace InitAndRequired
{
    public class Program
    {
        public static void Main()
        {
            var person = new InitAndRequiredExample
            {
                FirstName = "Mert Samet",
                LastName = "Yurttaş",
                Age = 30
            };

            Console.WriteLine($"{person.FirstName} {person.LastName}, Yaş: {person.Age}");
        }
    }
}
