using System.Collections;
using System.Text;

class ArrayListExample
    {
    public static void listeliExample()
    {
        ArrayList liste = new ArrayList();
        liste.Add(1);
        liste.Add("Ayşe");
        liste.Add(3.14);

        foreach (var item in liste)
        {
            System.Console.WriteLine(item);
        }



    }
    }
    


