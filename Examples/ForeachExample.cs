using System.Text;

internal class foreachExample
{
    public static void RunExample()
    {
        /*   int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

          foreach(int sayi in sayilar)
              {
              System.Console.WriteLine(sayi);
              } */

        string[] meyveler = { "Elma", "Armut", "Muz", "Çilek", "Karpuz" };
        foreach (string meyve in meyveler)
        {
            System.Console.WriteLine(meyve);
        }



    }
}




