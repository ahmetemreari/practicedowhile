# C# Programı: While ve Do-While Döngüleri

Bu C# programı, kullanıcıdan bir limit değeri alarak iki farklı döngü yapısını (while ve do-while) kullanarak belirli bir mesajı yazdırmaktadır. Program, "Ben bir Patika'lıyım" mesajını, kullanıcı tarafından belirlenen limit kadar tekrar eder.

## Özellikler

1. **While Döngüsü**: Kullanıcıdan alınan limit değerine kadar döngü çalışır. Koşul, döngünün başında kontrol edilir.
2. **Do-While Döngüsü**: Kullanıcıdan alınan limit değerine kadar döngü çalışır. Koşul, döngünün sonunda kontrol edilir, bu nedenle en az bir kez çalışır.

## Kod Açıklaması

### While Döngüsü

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Limit değerini giriniz: ");
        int limit = int.Parse(Console.ReadLine());
        int sayac = 0;

        while (sayac <= limit)
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac++;
        }
    }
}

*Kullanıcıdan bir limit değeri alınır.
*sayac değişkeni 0’dan başlar ve limit değerine kadar döngü devam eder.
## DO While Döngüsü
using System;

class Program
{
    static void Main()
    {
        Console.Write("Limit değerini giriniz: ");
        int limit = int.Parse(Console.ReadLine());
        int sayac = 0;

        do
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac++;
        } while (sayac <= limit);
    }
}
*Kullanıcıdan bir limit değeri alınır.
*sayac değişkeni 0’dan başlar ve döngü en az bir kez çalışır, ardından koşul kontrol edilir.
## Kullanım

Programı çalıştırmak için bir C# geliştirme ortamında derleyip çalıştırabilirsiniz. Kullanıcıdan limit değeri alındıktan sonra, belirlenen mesaj belirtilen sayıda yazdırılacaktır.
