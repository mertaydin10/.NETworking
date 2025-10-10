using System.Collections;

class HashTableExample
{
    public void Run()
    {
        Hashtable listem = new Hashtable();
        listem.Add(1, "Sude");
        listem.Add(2, "Gamze");
        listem.Add(3, "Elif");
        listem.Add(4, "Ece");
        listem.Add(5, "İrem");
        listem.Add(6, "Eylül");

        foreach (DictionaryEntry entry in listem)
        {
            System.Console.WriteLine($"Anahtar : {entry.Key} ,   Değer : {entry.Value}");
        }
    }
}