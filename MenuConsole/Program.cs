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
            int szulev = 0;

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
                    Console.WriteLine("Név: ");
                    nev = Console.ReadLine();

                    Console.WriteLine("Neve (f/n): ");
                    ffi = Console.ReadLine() == "f";

                    string szulevStr = "";
                    do
                    {
                        Console.WriteLine("Születési év: ");
                        szulevStr = Console.ReadLine();
                    } while (!int.TryParse(szulevStr, out szulev));
                    szulev = int.Parse(szulevStr);

                    Console.WriteLine("Sikeres adatrögzírtés! Folytatáshoz nyomjon Entert. ");
                    Console.ReadLine();


                }else if (valasz == "2")
                {
                    Console.WriteLine($"Név: {nev} \n" +
                        $"Neme: {(ffi ? "Férfi" : "Nő")}\n" +
                        $"Születési év: {szulev}");
                    Console.ReadLine();


                }else if (valasz == "3")
                {
                    Console.Beep();
                    Console.WriteLine("Biztosan ki szeretne lépni? (i/n)");
                    Console.Beep();
                    valasz = Console.ReadLine() != "i" ? " " : "3";


                }else
                {
                    Console.WriteLine("Nem létező menüpont!");
                    Console.ReadLine();
                }

            } while (valasz != "3");
        }
    }
}
