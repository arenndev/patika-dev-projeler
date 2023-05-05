namespace donguler_while_foreach;
class Program
{
    static void Main(string[] args)
    {
        // While
        // 1den başlayarak konsoldan girilen sayıya kadar (sayı dahil) ortalama hesaplama

        Console.Write("Lütfen Bir Sayı Giriniz:");
        int sayi = int.Parse(Console.ReadLine());
        int sayac = 1;
        int toplam = 0;

        while (sayac <= sayi)
        {
            toplam+= sayac;
            sayac ++;
        }
        Console.WriteLine(toplam/sayi);

        // a'dan z'ye kadar tüm harfleri console yazdır
        char character = 'a';
        while (character <= 'z')
        {
            Console.Write(character);
            character ++;
        }

        //Foreach
        Console.WriteLine("******Foreach******");
        

        string[] arabalar = {"BMW", "Ford", "Toyata", "Nissan"};

        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }

    }
}
