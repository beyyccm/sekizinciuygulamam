using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan limit değeri alınır
        Console.Write("Bir limit değeri giriniz: ");
        int limit = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n=== WHILE DÖNGÜSÜ ===");
        int sayac1 = 0;
        while (sayac1 <= limit)
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac1++;
        }

        Console.WriteLine("\n=== DO-WHILE DÖNGÜSÜ ===");
        int sayac2 = 0;
        do
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac2++;
        }
        while (sayac2 <= limit);

        /*
        FARKLAR:
        ----------------------------
        Örnek input: 10
        - Her iki döngüde de "Ben bir Patika'lıyım" mesajı 11 kez (0'dan 10 dahil) yazdırılır.

        Örnek input: -5
        - while döngüsü koşul baştan sağlanmadığı için hiçbir çıktı üretmez.
        - do-while döngüsü koşula bakmadan önce bir kez çalıştığı için en az 1 kez "Ben bir Patika'lıyım" mesajı yazdırır.

        Yani:
        WHILE: Koşul en başta kontrol edilir. Eğer koşul sağlanmazsa döngü hiç çalışmaz.
        DO-WHILE: Döngü gövdesi en az bir kere çalışır, çünkü koşul sonra kontrol edilir.
        */
    }
}
