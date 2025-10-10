using System.Text;

class sttringBuilder
    {
    public static void Main(string[] args)
    {
        string kurs = "C#";
        string tarih = "2024";

        StringBuilder builder = new StringBuilder();
        builder.Append(kurs);
        builder.Append(" ");
        builder.Append(tarih);

        System.Console.WriteLine(builder);


        }
    }


