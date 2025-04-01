// Bu örnekte C# 9 ve 11 ile gelen 'init' ve 'required' özellikleri kullanılmıştır.
// 'init' ile tanımlanan özellikler sadece nesne oluşturulurken atanabilir, sonradan değiştirilemez.
// 'required' ise bir nesne oluşturulurken mutlaka atama yapılması gereken alanlardır.
// Bu yapılarla immutable (değiştirilemez) ve kurallı veri modelleri oluşturmak mümkün olur.

using System;

namespace InitAndRequired
{
    public class InitAndRequiredExample
    {
        public required string FirstName { get; init; }
        public required string LastName { get; init; }
        public int Age { get; init; }
    }
}
