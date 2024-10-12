//while
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
////do-while
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
///While döngüsünde koşulu baştan kontrol eder , do while da ,ise sondan kontrol edilir o yüzden en az 1 kere çalışır.