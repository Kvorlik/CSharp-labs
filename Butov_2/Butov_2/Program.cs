using System;
using System.Threading;

namespace Butov_2{
    class Program{
        public static void WriteText(string str){
            Console.SetCursorPosition(0, (2 + (Console.WindowHeight / 2)));
            Console.Write(str);
            Console.SetCursorPosition(0, 3);
            string tempStr = str;
            string iter = "";
            string result = "";
            for(int j = 0; j < tempStr.Length; j++) {
                for(int i = 1; i <= tempStr.Length / 2; i++) {
                    iter = tempStr.Substring(0, i);
                    iter += iter;
                    if(tempStr.StartsWith(iter)) {
                        result += iter;
                        tempStr = tempStr.Substring(iter.Length);
                        i = 0;
                    }
                }
                if(tempStr.Length != 0) {
                    tempStr = tempStr.Substring(1);
                }
            }
            Console.Write(result);
        }

        public static void WriteInOutAndSize(){
            Console.SetCursorPosition(Console.WindowLeft, Console.WindowTop);
            Console.WriteLine(Console.WindowWidth + " " + Console.WindowHeight + "\n" + Console.WindowWidth + " " + ((Console.WindowHeight / 2) - 2));
            Console.SetCursorPosition(0, 2);
            Console.Write("Вывод: ");
            Console.SetCursorPosition(0, (1 + (Console.WindowHeight / 2)));
            Console.Write("Ввод: ");
        }

        static void Main(string[] args){
            string str = "";
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;
            ConsoleKeyInfo key;
            Console.TreatControlCAsInput = true;
            DateTime time = DateTime.Now;
            WriteInOutAndSize();

            do{
                Thread.Sleep(20);
                Console.CursorVisible = false;
                if(Console.KeyAvailable){
                    Console.SetCursorPosition(str.Length / Console.WindowWidth, (1 + (Console.WindowHeight) / 2) + (str.Length / Console.WindowWidth));
                    key = Console.ReadKey(true);
                    switch(key.Key){
                        case ConsoleKey.Backspace:
                            if(str.Length > 0){
                                str = str.Substring(0, str.Length - 1);
                            }
                            Console.Clear();
                            WriteText(str);
                            WriteInOutAndSize();
                            Thread.Sleep(1);
                            break;

                        case ConsoleKey.Escape:
                            return;

                        default:
                            str += key.KeyChar;
                            if(str.Length >= Console.WindowWidth * ((Console.WindowHeight / 2) - 2)){
                                str = str.Substring(1);
                            }
                            WriteText(str);
                            break;
                    }
                }

                if(height != Console.WindowHeight || width != Console.WindowWidth){
                    height = Console.WindowHeight;
                    width = Console.WindowWidth;
                    if(Console.WindowWidth >= 13 && Console.WindowHeight >= 6){
                        Console.Clear();
                        while(str.Length >= Console.WindowWidth * ((Console.WindowHeight / 2) - 2)){
                            str = str.Substring(1);
                        }
                        WriteInOutAndSize();
                        WriteText(str);
                    }
                }

                if(time.TimeOfDay.Subtract(DateTime.Now.TimeOfDay).TotalMilliseconds <= 50){
                    time = DateTime.Now;
                    if(Console.WindowWidth >= 8 && Console.WindowHeight >= 1){
                        Console.SetCursorPosition(Console.WindowWidth - 8, Console.WindowTop);
                    }
                    Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
                }
            } while(true);
        }
    }
}
