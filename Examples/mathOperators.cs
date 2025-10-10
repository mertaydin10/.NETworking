using System.Text;

class mathOperators
    {
    public static void Main(string[] args)
    {

        ///                         MATEMATİKSEL FONKSİYONLAR

        /*   System.Console.WriteLine("1.sayıyı girin:");
           int sayi1 = Convert.ToInt32(Console.ReadLine());

           System.Console.WriteLine("2.sayıyı girin:");
           int sayi2 = Convert.ToInt32(Console.ReadLine());  /*

           // Math.Max fonksiyonu örneği

           /* int enBuyuk = Math.Max(sayi1, sayi2);
            Console.WriteLine($"Girdiğiniz sayılar {sayi1} ve {sayi2} 4\nEn büyük sayı: {enBuyuk}"); */

        // Math.Min fonksiyonu örneği

        /*   int enKucuk = Math.Min(sayi1, sayi2);
           Console.WriteLine($"Girdiğiniz sayılar {sayi1} ve {sayi2} \nEn küçük sayı: {enKucuk}"); */

        // Math.Sqrt fonksiyonu örneği 

        Console.WriteLine("Bir sayı girin:");
        int sayiAl = Convert.ToInt32(Console.ReadLine());
        double karekok = Math.Sqrt(sayiAl);
        Console.WriteLine($"{sayiAl} sayısının karekökü: {karekok}");

        //Console.WriteLine($"Girdiğiniz sayının karekökü: {Math.Sqrt(sayiAl)}");





    }
    }


