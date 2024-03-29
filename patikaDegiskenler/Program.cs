﻿using System;

namespace degiskenler;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("");
        byte b = 5;     // 1 byte
        sbyte c =5;     // 1 byte

        short s = 5;    // 2 byte yer kaplar
        ushort us = 5;  // 2 byte 

        Int16 i16 = 2;  // 2 byte
        int i = 2;      // 4 byte 
        Int32 i32 = 2;  // 4 byte
        Int64 i64 = 2;  // 8 byte

        uint ui= 2;     // 4 byte
        long l = 4;     // 8 byte
        ulong ul = 4;   // 8 byte

        // reel sayılar
        float f = 3;    // 4 byte 
        double d = 5;   // 8 byte
        decimal de = 5; // 16 byte 

        char ch = '2';  // 2 byte
        string str = "Umut"; //sınırsız

        bool b1 = true;
        bool b2 = false;

        DateTime dt = DateTime.Now;

        object o1 ="x";
        object o2 ="y";
        object o3 = 4 ;
        object o4 = 4.3;

        // string ifadeler
        string str1 = string.Empty;
        str1 = "Umut";
        string ad = "Umut";
        string soyad = "Kuzu";
        string tamIsim = ad +" " + soyad;


        //integer tanımlama şekilleri

        int integer1 = 5;
        int integer2 = 3;
        int intger3 = integer1 + integer2 ;

        //boolean
        
        bool bol1 = 10>2;

        //Değişken Dönüşümleri
        string str20 ="20";
        int int20 = 20;
        string yenideger = str20 + int20.ToString();
        //Console.WriteLine(yenideger); //çıktı 2020
        //Console.ReadLine();
    

        int int21= int20 + Convert.ToInt32(str20);
        //Console.WriteLine(int21); // çıktı 40
        //Console.ReadLine();

        int int22 = int20 + int.Parse(str20);
        //Console.WriteLine(int22); // çıktı 40
        //Console.ReadLine();
        

        //datetime
        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(datetime);
        

        string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
        Console.WriteLine(datetime2);
        

        string hour = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);
        Console.ReadLine();
    }
}