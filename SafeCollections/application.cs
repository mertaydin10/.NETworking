using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Text;
using ConsoleApp1;

namespace ConsoleApp1;



class Program 
{
    public static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add("Hello");
        arrayList.Add(3.14);

        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        // list.Add("Mehmet"); ERROR

        List<string> lists = new List<string>();
        lists.Add("Hello");
        // lists.Add(1); ERROR
    }


}

