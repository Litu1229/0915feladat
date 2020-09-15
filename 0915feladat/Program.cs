using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _0915feladat
{
    class Ember
    {
        public string nev;
        public int eletkor;
        public string Bemutatkozas()
        { 
            string s =$"{nev} vagyok {eletkor} éves";
            return s;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ember pisti = new Ember();
            pisti.nev = "Tóth Pisti";
            pisti.eletkor = 26;
            

            Ember eva = new Ember();
            eva.nev = "Nagy Éva";
            eva.eletkor = 20;


            Console.WriteLine(pisti.Bemutatkozas());
            Console.WriteLine(eva.Bemutatkozas());
            Console.ReadKey();
        }
    }
}
