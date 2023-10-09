using System;
using System.Collections;
using System.Collections.Generic;
namespace arraylist
{

    class ArrayListler
    {
        public static void Main(string[] args)
        {

            ArrayList liste = new ArrayList();

            liste.Add("Sefa");
            liste.Add("1922");
            liste.Add(true);
            liste.Add('A');

            foreach (var eleman in liste)
            {
                Console.WriteLine(eleman);
            }

            //Addrange=Birden fazla elemanı toplu ekleme.

            Console.WriteLine("**********");
            string[] renkler = { "Yeşil", "Beyaz", "Siyah" };
            List<int> sayilar = new List<int>() { 99, 45, 26, 5, 35, 79, 12, 32 };
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sadece int değerleri sıralayabilir
            // Console.WriteLine("*****Short******");

            // liste.Sort();
            // foreach (var item in liste)
            // {
            //     Console.WriteLine(item);
            // }

            // Console.WriteLine("*******Binary Search***********");
            // Console.WriteLine(liste.BinarySearch(26));

            // //Reverse

            // Console.WriteLine("*******Reveerse***********");
            // liste.Reverse();
            // foreach (var item in liste)
            // {
            //     Console.WriteLine(item);
            // }

            // // Clear

            // Console.WriteLine("*******Clear***********");
            // liste.Clear();
            // foreach (var item in liste)
            // {
            //     Console.WriteLine(item);
            // }
        }
    }

}
