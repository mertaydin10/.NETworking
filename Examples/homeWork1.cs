 class homeWork1
    {
    public static void Main(string[] args)
    {
        Console.Write("Adınızı giriniz: ");
        string name = Console.ReadLine();
        Console.Write("Soyadınızı giriniz: ");
        string surname = Console.ReadLine();
        Console.Write("Yaşınızı giriniz: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hoşgeldin " + name + " " + surname + ", yaşınız " + age);




        }
    }
