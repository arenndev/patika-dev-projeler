﻿namespace donguler_for_loop;
class Program
{
    static void Main(string[] args)
    {   

        // //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
        // Console.WriteLine("Lütfen bir sayi giriniz.");

        // int sayac = int.Parse(Console.ReadLine());
        // for (int i = 1; i < sayac; i++)
        // {
            
        //     if(i%2 == 1)
        //     Console.WriteLine(i);
        // }

        // // 1 ile 1000 arasındaki tek ve çift sayıların toplamını hesapla

        // int tekToplam = 0;
        // int ciftToplam = 0;


        // for (int i = 1; i < 1000; i++)
        // {
        //     if(i%2 == 1)
        //         tekToplam += i; // tekToplam = Tektoplam + i
        //     else
        //         ciftToplam += i; // cıfToplam = cıftToplam + i
        // }
        // Console.WriteLine("Tek Toplam: " + tekToplam);
        // Console.WriteLine("Çift Toplam:" + ciftToplam);

        //break, continue

        for (int i = 1; i < 10; i++)
        {
            if(i == 4)
            break;
            Console.WriteLine(i);
        }


        for (int i = 1; i < 10; i++)
        {
            if(i == 4)
            continue;
            Console.WriteLine(i);
        }


    }   

}
