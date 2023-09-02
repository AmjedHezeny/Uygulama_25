using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>()
            {
                25, 6, 398, -754, 521, 69, -584, -6, 3, 9, 12, 4, -2, 84, 972
            };

            Console.WriteLine("****************************************");
            Console.WriteLine("Tüm Sayıları Ekrana Yazdır.");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            var list = from sayi in sayilar select sayi;
            Console.WriteLine("Tüm Sayılar");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            Console.WriteLine("****************************************");
            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine("Küçükten Büyüğe Sıralanmış Sayıları Ekrana Yazdır.");
            Console.WriteLine("----------------------------------------");
            var kbSayilar = from sayi in sayilar
                            orderby sayi ascending
                            select sayi;
            Console.WriteLine();
            Console.WriteLine("Küçükten Büyüğe Sıralanmış Sayılar.");
            foreach (var item in kbSayilar)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("****************************************");
            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine("Büyükten küçüğe sıralanmış sayıları ekrana yazdır.");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            var bkSayilar = from s in sayilar
                            orderby s descending
                            select s;
            Console.WriteLine("Büyükten Küçüğe Sıralanmış Sayılar:");
            foreach (var item in bkSayilar)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("****************************************");
            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine("2'ye Bölünebilen Sayıları Ekrana Yazdır.");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            var bolunen2 = from s in sayilar
                           where s % 2 == 0
                           select s;
            Console.WriteLine("2'ye Bölünebilen Sayılar.");
            foreach (var item in bolunen2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            Console.WriteLine("****************************************");
            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine("4'e Bölünen Ve 7'ye Bölünmeyen Sayıları Küçükten Büyüğe Sırala Ve Ekrana Yazdır.");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            var bolunen4 = from s in sayilar
                           where s % 4 == 0 && s % 7 != 0
                           orderby s ascending
                           select s;
            Console.WriteLine("4'e Bölünen ve 7'ye Bölünmeyen Sayılar.");
            foreach (var item in bolunen4)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            Console.WriteLine("****************************************");
            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.WriteLine("3'e Tam Bölünebilen Sayıların En Küçüğünü Ve En Büyüğünü Ekrana Yazdır.");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            var bolunen3 = from s in sayilar
                           where s % 3 == 0
                           orderby s ascending
                           select s;

            Console.WriteLine("3'e Bölünebilen Sayıların En Küçüğü : " + bolunen3.Min());
            Console.WriteLine("3'e Bölünebilen Sayıların En Büyüğü : " + bolunen3.Max());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
