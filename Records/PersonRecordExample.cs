using System;

// Bu örnekte C# 9 ile gelen record yapısı kullanılmıştır.
// record, immutable (değiştirilemez) veri modelleri tanımlamak için kullanılır.
// record ile değer (value-based) eşitliği yapılabilir. Referans yerine içeriği karşılaştırır.
// 'with' ifadesiyle var olan bir record'dan kopya oluşturup bazı alanlar değiştirilebilir.
// Otomatik olarak ToString, Equals, GetHashCode metodları override edilir.

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

// Bu yapı DTO (veri transfer nesneleri) gibi sadece veri tutan modeller için uygundur.
// Sınıf yerine record kullanmak kodun daha sade, güvenli ve okunabilir olmasını sağlar.
