using System;
using System.Collections.Generic;

namespace soru1

{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru-1
            //Klavyeden Girilen 20 adet pozitif sayı al.
            //asal olan ve olmayan olarak ayrı ayrı 2 listeye at.
            //negatif ve numeric olamayan girişleri engelle.
            //Her bir dizininin elemanlarını büyükten küçüğe ekrana listele
            //her iki dizininde eleman sayısı ve ortalamasını ekrana yazdır.
            int sayac;
            int sayi;
            List<int> asallist = new List<int>();
            List<int> asalolmayanlist = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                try
                {
                    sayac = 0;
                    System.Console.WriteLine("Lütfen {0}. Sayıyı Giriniz.", i + 1);
                    sayi = int.Parse(Console.ReadLine());
                    for (int x = 2; x < sayi; x++)
                    {

                        if (sayi % x == 0)
                        {
                            sayac++;
                        }
                    }
                    if (sayac == 0)
                    {
                        asallist.Add(sayi);
                    }
                    else
                    {
                        asalolmayanlist.Add(sayi);
                    }
                }
                catch
                {
                    System.Console.WriteLine("Lütfen Pozitif Ve Sayısal Bir Değer Giriniz.");
                }
            }
            System.Console.WriteLine("Asal Sayılar");
            foreach (var item in asallist)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("Asal olmayan sayılar");
            foreach (var item in asalolmayanlist)
            {
                System.Console.WriteLine(item);
            }
            //Listeleri Büyükten Küçüğe Listele
            asallist.Sort();
            asallist.Reverse();
            asalolmayanlist.Sort();
            asalolmayanlist.Reverse();
            System.Console.WriteLine("** Asal olan listenin büyükten küçüğe sıralanışı **");
            foreach (var item in asallist)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("** Asal olmayan listenin büyükten küçüğe sıralanışı **");
            foreach (var item in asalolmayanlist)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine(asallist.Count);
            System.Console.WriteLine("Asal Olan Listede {0} Eleman Bulunmaktadır.", asallist.Count);
            System.Console.WriteLine("Asal Olmayan Listede {0} Eleman Bulunmaktadır.", asalolmayanlist.Count);
            int asallistsayitotal = 0;
            foreach (var item in asallist)
            {
                asallistsayitotal += item;
            }
            double asallistsayiavr = asallistsayitotal / asallist.Count;
            System.Console.WriteLine("Asal Olan Listenin Ortalaması {0}'dır.", asallistsayiavr);
            int asalolmayanlistsayitotal = 0;
            foreach (var item in asallist)
            {
                asalolmayanlistsayitotal += item;
            }
            double asalolmayanlistsayiavr = asalolmayanlistsayitotal / asalolmayanlist.Count;
            System.Console.WriteLine("Asal Olan Listenin Ortalaması {0}'dır.", asalolmayanlistsayiavr);

            //Soru-2
            //klavyeden girilen 20 adet sayının en küçük 3 değeri ve en büyük 3 değerini al
            //her iki grubunda ortalamasını ver ortalama toplamlarını yazdır.
            int[] sayiDizisi = new int[20];
            for (int i = 0; i < 20; i++)
            {
                System.Console.WriteLine("Lütfen {0}. Sayıyı Giriniz.", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            int[] minValues = new int[3];
            int[] maxValues = new int[3];
            Array.Sort(sayiDizisi);
            double minValueAvr = 0;
            for (int i = 0; i < 3; i++)
            {
                minValues[i] = sayiDizisi[i];
            }
            System.Console.WriteLine("Dizideki En küçük 3 Eleman");
            foreach (var item in minValues)
            {
                System.Console.WriteLine(item);
                minValueAvr += item;
            }
            double maxValueAvr = 0;
            Array.Reverse(sayiDizisi);
            for (int i = 0; i < 3; i++)
            {
                maxValues[i] = sayiDizisi[i];
            }
            System.Console.WriteLine("Dizideki En Büyük 3 Eleman");
            foreach (var item in maxValues)
            {
                System.Console.WriteLine(item);
                maxValueAvr += item;
            }
            System.Console.WriteLine("Küçükler Dizisinin Ortalaması: " + minValueAvr / 3);
            System.Console.WriteLine("Byükler Dizisinin Ortalaması: " + maxValueAvr / 3);
            System.Console.WriteLine("Küçükler Dizisinin Ortalama Toplamları: " + minValueAvr);
            System.Console.WriteLine("Büyükler Dizisinin Ortalama Toplamları: " + maxValueAvr);

            //Soru-3
            //klavyeden Girilen Cümle İçerisindeki Sesli harfleri al
            //bir diziye aktar ve diziyi sıralı yazdır.

            List<char> sesliList = new List<char>();
            string sesliChar = "aeıioöuü";
            System.Console.WriteLine("Lütfen Bir Kelime Giriniz.");
            string metin = Console.ReadLine().ToLower();
            for (int i = 0; i < metin.Length; i++)
            {
                if (sesliChar.Contains(metin[i]))
                {

                    sesliList.Add(metin[i]);
                }

            }
            if (sesliList.Count > 0)
            {
                foreach (var item in sesliList)
                {
                    System.Console.WriteLine(item);
                }
            }
            else
            {
                System.Console.WriteLine("Girilen Cümlede Sesli Harf Bulunmamaktadır.");
            }





        }
    }
}