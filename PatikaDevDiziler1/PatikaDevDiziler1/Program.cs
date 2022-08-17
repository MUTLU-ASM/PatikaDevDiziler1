using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDevDiziler1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi Tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            int[] dizi;
            dizi = new int[5];

            //Dizilere Değer Atama ve erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(renkler[0]);
            Console.WriteLine(hayvanlar[3]);
            Console.WriteLine(dizi[3]);

            //Döngülerle dizi kullanımı
            //Klavyeden girilen n tane sayının ortalamasını hesaplayan program

            Console.WriteLine("Lütfen dizi eleman sayisini giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayısını giriniz", i +1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam=0;
            foreach (var sayi in sayiDizisi)
                toplam += sayi;

            Console.WriteLine("ortalama : " + toplam / diziUzunlugu);

            Console.ReadLine();
        }
    }
}
