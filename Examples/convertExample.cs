 class convertExample
    {
    public static void Main(string[] args)
    {
        string ad = "John";
        int sayi = 14;
        float sayi2 = 10.7f;

        string newValue = Convert.ToString(sayi);

        int newValue2 = Convert.ToInt32(newValue);

        Console.WriteLine(ad + " " + ad.GetType());
        Console.WriteLine(sayi + " " + sayi.GetType());
        Console.WriteLine(sayi2 + " " + sayi2.GetType());
        Console.WriteLine(newValue + " " + newValue.GetType());
        Console.WriteLine(newValue2 + " " + newValue2.GetType());
        
        }
    }


