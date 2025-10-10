using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{

    class Araba
    {
        public string marka;  //= "Volkswagen";
        public string model; //  ="Golf";
        public string renk; // ="Beyaz";
        public int yıl; //= 2015;


       public  Araba(string marka, string model, string renk, int yıl)
        {
            this.marka = marka;
            this.model = model;
            this.renk = renk;
            this.yıl = yıl;
    }



        public void printInfo()
        {
            Console.WriteLine($"Marka: {marka}, Model: {model}, Renk: {renk}, Yıl: {yıl}");
        }


      /* public void degerAtama(string marka, string model, string renk, int yıl)
        {
            this.marka = marka;
            this.model = model;
            this.renk = renk;
            this.yıl = yıl;
    }   */
    
       
    
}

}