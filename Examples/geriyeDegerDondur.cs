using System.Collections;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        /* Toplama();
         Console.WriteLine("İşlem tamamlandı."); */

        System.Console.WriteLine("Birinci sayıyı giriniz:");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("İkinci sayıyı giriniz:");
        int sayi2 = Convert.ToInt32(Console.ReadLine());


        /* System.Console.WriteLine($"Girdiğiniz sayıların toplamı : {Topla(sayi1, sayi2)}");
         Console.WriteLine("İşlem tamamlandı."); */


        int sonuc = Topla(sayi1, sayi2);
        System.Console.WriteLine($"Girdiğiniz sayıların toplamı : {sonuc}");

        double sonuc2 = Topla(5.4, 3.2);
        System.Console.WriteLine($"Girdiğiniz ondalıklı sayıların toplamı : {sonuc2}");

    }


    /* static void Toplama()
     {
         Console.WriteLine("İlk sayıyı  giriniz:");
         int sayi1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("İkinci sayıyı  giriniz:");
         int sayi2 = Convert.ToInt32(Console.ReadLine());

         int toplam = sayi1 + sayi2;
         Console.WriteLine($"Girdiğiniz sayıların toplamı : {toplam}");
     }  */



    /*  static void Topla(int s1, int s2)
      {
          int toplam = s1 + s2;
          Console.WriteLine($"Girdiğiniz sayıların toplamı : {toplam}");
      } */

    static int Topla(int s1, int s2)
    {
        return s1 + s2;
    }

     static double Topla(double s1, double s2)
    {
        return s1 + s2;

}
    
}


