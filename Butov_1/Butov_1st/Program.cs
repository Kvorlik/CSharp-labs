using System;
using Butov_ClassLibrary;

namespace Butov_1st{
    static class Program{
        static void Main(string[] args){
            ConsoleKeyInfo cki;
            do{
                Console.Write("1. Enter variables.\n" +
                    "2. Calculate and take result.\n" +
                    "3. Exit.\n" +
                    "Choose an action: ");
                cki = Console.ReadKey();
                Console.Clear();
                if ((cki.Key != ConsoleKey.D1) && (cki.Key != ConsoleKey.D2) && (cki.Key != ConsoleKey.D3) &&
                    (cki.Key != ConsoleKey.NumPad1) && (cki.Key != ConsoleKey.NumPad2) && (cki.Key != ConsoleKey.NumPad3)){
                    Console.WriteLine("Error. Choose 1-3.");
                    Console.Write("Press any key...");
                    Console.ReadKey(true);
                    Console.Clear();
                    continue;
                }
                switch (cki.Key){
                    case ConsoleKey.D1: Calculations.VarInput(); break;
                    case ConsoleKey.D2: Calculations.CalcAndShow(); break;
                    case ConsoleKey.D3: break;
                    case ConsoleKey.NumPad1: Calculations.VarInput(); break;
                    case ConsoleKey.NumPad2: Calculations.CalcAndShow(); break;
                    case ConsoleKey.NumPad3: break;
                }
            }
            while ((cki.Key != ConsoleKey.D3) && (cki.Key != ConsoleKey.NumPad3));
            Console.Write("Press any key...");
            Console.ReadKey(true);
        }
    }
}