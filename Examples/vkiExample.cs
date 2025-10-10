using System.Collections;
using System.Text;

class vkiExample
{
    public  void VkiExample()
    {
        System.Console.WriteLine("Boyunuzu (metre cinsinden) giriniz:");
        double boy = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Kilonuzu (kg cinsinden) giriniz:");
        double kilo = Convert.ToDouble(Console.ReadLine());

        double bmi = Oran(boy, kilo);

        System.Console.WriteLine(bmi);

        string durum = Durum(bmi);
        System.Console.WriteLine(durum);



    }


    static double Oran(double boy, double kilo)
    {
        return (kilo / (boy * boy));
    }

    static string Durum(double bmi)
    {

        string durum = "";
        if (bmi < 18.5)
        {
            durum = "Zayıf";
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            durum = "Normal";
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            durum = "Fazla Kilolu";
        }
        else
        {
            durum = "Obez";
        }


        return durum;
    }
}