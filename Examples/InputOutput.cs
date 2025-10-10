 class InputOutput
    {
    public static void InputOutputExample()
    {
        /*  Console.Write("Bir şeyler yazın: ");
          string gelenDeger = Console.ReadLine();
              Console.WriteLine( "Girdiğiniz Değer:"  + " "  + gelenDeger); */

        Console.Write("Bir sayı girin: ");
        int gelenDeger = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Girdiğiniz Değer:" + " " + gelenDeger + " " + gelenDeger.GetType());

        }
    }


