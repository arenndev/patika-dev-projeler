namespace switch_case;
class Program
{
    static void Main(string[] args)
    {
        int month = DateTime.Now.Month;
        
        //Expression
        switch (month) 
        {
            case 1:
                Console.WriteLine("Ocak Ayındasınız.");
                break;
            case 2:
                Console.WriteLine("Şubat Ayındasınız.");
                break;
            case 5:
                Console.WriteLine("Mayıs Ayındasınız.");
                break;    
            default:
                Console.WriteLine("Yanlış veri girişiyaptınız");
            break;
        }

        switch (month)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Kış");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("İlkbahar");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("Yaz");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Sonbahar");
                break;


            default:
            break;
        }
    }
}
