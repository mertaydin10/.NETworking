using System.Collections;
using System.Text;

class stackExample
{
    public static void stackExample()
    {
        Stack listem = new Stack();

        listem.Push("Eylul");
        listem.Push("Sude");
        listem.Push("Hatice");
        listem.Push("İrem");

        System.Console.WriteLine(listem.Pop());
        System.Console.WriteLine(listem.Peek());

    }
}
    


