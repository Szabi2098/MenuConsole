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
            Console.BackgroundColor = ConsoleColor.DarkMagenta; // sötét lila háttér
            Console.ForegroundColor = ConsoleColor.White;       // fehér betűszín
            Console.Clear();
            string nev = "";
            bool ffi = true;
            int szulev = 0;

            string valasz = "";
            do
            {
                Console.Clear();
                Console.Title = "Személyes adatok kezelése";
                Console.SetCursorPosition(5, 0);
                Console.WriteLine("---- Személyes adatok kezelése ---- \n");
                Console.SetCursorPosition(8, 2);
                Console.WriteLine("1 - Személyes adatok bevitele");
                Console.SetCursorPosition(8, 3);
                Console.WriteLine("2 - Személyes adatok kiírása");
                Console.SetCursorPosition(8, 4);
                Console.WriteLine("3 - Kilépés");
                Console.SetCursorPosition(8, 6);
                Console.WriteLine("Menüpont számával választhat");
                valasz = Console.ReadLine();

                if (valasz == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Név: ");
                    nev = Console.ReadLine();

                    Console.WriteLine("Neme (f/n): ");
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
                    Console.Clear();
                    Console.WriteLine($"Név: {nev} \n" +
                        $"Neme: {(ffi ? "Férfi" : "Nő")}\n" +
                        $"Születési év: {szulev}");
                    Console.ReadLine();


                }else if (valasz == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Biztosan ki szeretne lépni? (i/n)");
                    valasz = Console.ReadLine() != "i" ? " " : "3";


                }else
                {
                    Console.Clear();
                    Console.WriteLine("Nem létező menüpont!");
                    Console.ReadLine();
                }

            } while (valasz != "3");
        }
    }
}
    