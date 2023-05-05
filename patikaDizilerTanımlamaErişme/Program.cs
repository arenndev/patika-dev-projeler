namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        // Dizi Tanımlama
        string[] renkler = new string[5];

        string[] hayvanlar = {"Kedi", "Köpek", "Kuş", "Maymun"};

        int[] dizi;
        dizi = new int[5];

        // Diziler Değer Atama ve Erişim
        renkler[0] = "Mavi";
        dizi[3] = 10;

         Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);
        

        //Döngüler ile dizi kullanımı

        //Klavyeden girilen n tane sayının ortalamasını alan program

        Console.Write("Lütfen dizinin eleman sayisini giriniz:");
        int diziUzuluğu = int.Parse(Console.ReadLine());
        int[] sayiDizisi = new int[diziUzuluğu];

        for (int i = 0; i < diziUzuluğu; i++)
        {
            Console.Write("Lütfen {0}. sayiyi giriniz:" , i+1);
            sayiDizisi[i] = int.Parse(Console.ReadLine());
        }

        int toplam = 0;
        foreach (var sayi in sayiDizisi)
            toplam += sayi;

        Console.WriteLine("Ortalama :"+ toplam/diziUzuluğu);
    }
}
