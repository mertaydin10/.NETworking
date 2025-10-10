 class homeWork2
    {
    public static void Main(string[] args)
    {

        Console.Write("İlk sayıyı  giriniz: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("İkinci sayıyı giriniz: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        int toplam = sayi1 + sayi2;
        Console.WriteLine("Girdiğiniz sayıların toplamı: " + toplam);
        int fark = sayi1 - sayi2;
        Console.WriteLine("Girdiğiniz sayıların farkı: " + fark);
        int carpim = sayi1 * sayi2;
        Console.WriteLine("Girdiğiniz sayıların çarpımı: " + carpim);
        float bolum = (float)sayi1 / (float)sayi2;
        Console.WriteLine("Girdiğiniz sayıların bölümü: " + bolum);
        




        }
    }


