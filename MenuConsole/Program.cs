using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nev = "";
            bool ffi = true;
            int szulev;

            string valasz = "";
            do
            {
                Console.Clear();
                Console.Title = "Személyes adatok kezelése";
                Console.WriteLine("---- Személyes adatok kezelése ---- \n");
                Console.WriteLine("1 - Személyes adatok bevitele");
                Console.WriteLine("2 - Személyes adatok kiírása");
                Console.WriteLine("3 - Kilépés");
                Console.WriteLine("Menüpont számával választhat");
                valasz = Console.ReadLine();

                if (valasz == "1")
                {
                    Console.WriteLine("Sikeres adatrögzírtés! Folytatáshoz nyomjon Entert. ");
                    Console.ReadLine();

                }else if (valasz == "2")
                {


                }else if (valasz == "3")
                {


                }else
                {
                    Console.WriteLine("Nem létező menüpont!");
                }

            } while (valasz != "3");
        }
    }
}
