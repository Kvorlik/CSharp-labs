using System;

namespace Butov_ClassLibrary{
    public static class Calculations{
        private static int A = 0;
        private static int B = 0;
        private static double X = 0;
        private static double Y = 0;
        private const string letter = "A letter was entered. Replaced with 1.";
        private static int IntCheckLetter(char Var){
            string tmp;
            Console.Write(Var + ": ");
            if (Int32.TryParse(tmp = Console.ReadLine(), out int OutValue)) return OutValue;
            else{
                Console.WriteLine(letter);
                return 1;
            }
        }
        private static double DoubleCheckLetter(char Var){
            string tmp;
            Console.Write(Var + ": ");
            if (Double.TryParse(tmp = Console.ReadLine(), out double OutValue)) return OutValue;
            else{
                Console.WriteLine(letter);
                return 1;
            }
        }
        public static void VarInput(){
            Console.WriteLine("Enter your variables here:");
            A = IntCheckLetter('A');
            B = IntCheckLetter('B');
            X = DoubleCheckLetter('X');
            Y = DoubleCheckLetter('Y');
            Console.Clear();
        }
        public static void CalcAndShow(){
            double result = ((A * X) / (B * X * Y)) / (X + 1);
            Console.WriteLine($"There is the result: {result}");
        }
    }
}