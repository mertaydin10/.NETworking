using System.Collections;
using System.Text;

class sortedListExample
    {
    public static void Main(string[] args)
    {
        SortedList liste = new SortedList();
        liste.Add(3, "Elif");
        liste.Add(10, "Sude");
        liste.Add(4, "Ece");
        liste.Add(2, "Gamze");
        liste.Add(7, "Eylül");
        liste.Add(5, "İrem");
        liste.Add(8, "Aslı");

        foreach (DictionaryEntry entry in liste)
            {
            System.Console.WriteLine($"Anahtar : {entry.Key} ,   Değer : {entry.Value}");
            }



    }
    }
    


