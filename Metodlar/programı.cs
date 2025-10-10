using System.Collections;
using System.Text;
using ConsoleApp1;

class Program
{

    public static void Main(string[] args)
    {

         Araba araba = new Araba("Renault", "Clio", "Mavi", 2023);
       /*  araba.marka = "BMW";
        araba.model = "520i"; */
        araba.printInfo();  

        Araba araba2 = new Araba("Mercedes", "C180", "Siyah", 2011);
      //  araba2.degerAtama("Mercedes", "C180", "Siyah", 2011);
        araba2.printInfo();
    }
}