// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        string[] kelimeler = { "elma", "armut", "muz", "kiraz", "karpuz" };
        Random rastgele = new Random();
        string secilenKelime = kelimeler[rastgele.Next(kelimeler.Length)];
        string tahmin = "";
        int hak = 5;
        int puan = 100; // Başlangıç puanı

        Console.WriteLine("🎮 Kelime Tahmin Oyununa Hoş Geldin!");
        Console.WriteLine("İpucu: Meyve isimlerinden biri. Toplam 5 hakkın var.\n");

        while (hak > 0)
        {
            Console.Write("Tahmin et: ");
            tahmin = Console.ReadLine().ToLower();

            if (tahmin == secilenKelime)
            {
                int bonus = hak * 10;
                puan += bonus;
                Console.WriteLine($"✅ Tebrikler! Doğru bildin 🎉 +{bonus} puan bonus!");
                break;
            }
            else
            {
                hak--;
                puan -= 20;
                Console.WriteLine($"❌ Yanlış tahmin! -20 puan | Kalan hakkın: {hak}");
            }
        }

        if (hak == 0)
        {
            Console.WriteLine($"😢 Hakkın bitti! Doğru cevap: {secilenKelime}");
        }

        Console.WriteLine($"\n🏁 Toplam Puanın: {puan}");
        Console.WriteLine("Oyun bitti, çıkmak için Enter’a bas...");
        Console.ReadLine();
    }
}
