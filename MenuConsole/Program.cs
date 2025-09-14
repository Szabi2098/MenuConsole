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
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
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
                Console.SetCursorPosition(8, 7);
                valasz = Console.ReadLine();

                if (valasz == "1")
                {
                    Console.Clear();
                    Console.SetCursorPosition(8, 0);
                    Console.WriteLine("Név: ");
                    Console.SetCursorPosition(8, 1);
                    nev = Console.ReadLine();

                    Console.SetCursorPosition(8, 2);
                    Console.WriteLine("Neme (f/n): ");
                    Console.SetCursorPosition(8, 3);
                    ffi = Console.ReadLine() == "f";

                    string szulevStr = "";
                    do
                    {
                        Console.SetCursorPosition(8, 4);
                        Console.WriteLine("Születési év: ");
                        Console.SetCursorPosition(8, 5);
                        szulevStr = Console.ReadLine();
                    } while (!int.TryParse(szulevStr, out szulev));
                    szulev = int.Parse(szulevStr);

                    Console.SetCursorPosition(8, 7);
                    Console.WriteLine("Sikeres adatrögzírtés! Folytatáshoz nyomjon Entert. ");
                    Console.SetCursorPosition(8, 8);
                    Console.ReadLine();


                }else if (valasz == "2")
                {
                    Console.Clear();
                    Console.SetCursorPosition(8, 0);
                    Console.WriteLine($"Név: {nev}");
                    Console.SetCursorPosition(8, 1);
                    Console.WriteLine($"Neme: {(ffi ? "Férfi" : "Nő")}");
                    Console.SetCursorPosition(8, 2);
                    Console.WriteLine($"Születési év: {szulev}");
                    Console.SetCursorPosition(8, 4);
                    Console.ReadLine();


                }else if (valasz == "3")
                {
                    Console.Clear();
                    Console.SetCursorPosition(8, 0);
                    Console.WriteLine("Biztosan ki szeretne lépni? (i/n)");
                    Console.SetCursorPosition(8, 1);
                    valasz = Console.ReadLine() != "i" ? " " : "3";


                }else
                {
                    Console.Clear();
                    Console.SetCursorPosition(8, 0);
                    Console.WriteLine("Nem létező menüpont!");
                    Console.SetCursorPosition(8, 1);
                    Console.ReadLine();
                }

            } while (valasz != "3");
        }
    }
}
    