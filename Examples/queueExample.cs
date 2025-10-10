using System.Collections;
using System.Text;

class queueExample
{
    public static void Main(string[] args)
    {
        // foreachExample.RunExample();
        // InputOutput.InputOutputExample();
        //ArrayListExample.listeliExample();

        Queue listem = new Queue();
        listem.Enqueue("İrem");
        listem.Enqueue("Eylul");
        listem.Enqueue("Hatice");
        listem.Enqueue("Sude");

        System.Console.WriteLine(listem.Dequeue());
        System.Console.WriteLine(listem.Peek());
        System.Console.WriteLine(listem.Dequeue());
        System.Console.WriteLine(listem.Peek());

    }
}
    


