using System.Text;

class switchExample
    {
    public static void Main(string[] args)
    {
        /// SWITCH ÖRNEĞİ YAPALIM

    while (true)
        {

        Console.WriteLine("Birinci sayı girin:");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("İkinci sayı girin:");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Yapmak istediğiniz işlemi seçin: +, -, *, /");
        string islem = Console.ReadLine();
        double sonuc = 0;

        switch(islem)
            {
            case "+":
                sonuc = sayi1 + sayi2;
                System.Console.WriteLine($"Sonuç: {sonuc}");
                break;
            case "-":
                sonuc = sayi1 - sayi2;
                System.Console.WriteLine($"Sonuç: {sonuc}");
                break;
            case "*":
                sonuc = sayi1 * sayi2;
                System.Console.WriteLine($"Sonuç: {sonuc}");
                break;
            case "/":
                if (sayi2 != 0)
                {
                    sonuc = (double)sayi1 / sayi2;
                    System.Console.WriteLine($"Sonuç: {sonuc}");
                    }
                else
                {
                    Console.WriteLine("Bir sayı sıfıra bölünemez.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Geçersiz işlem seçimi.");
                return;
                }
            }
        }
    }


