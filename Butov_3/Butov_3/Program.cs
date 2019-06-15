using System;
using System.Threading;

namespace Butov_3 {
    class Program {
        static readonly object _locker = new object();

        public class Data {
            public string str = "";
            public string modifiedStr = "";
            public bool end = false;
            public int width = Console.WindowWidth;
            public int height = Console.WindowHeight;
            public DateTime time = DateTime.Now;
        }

        static void OutTask(object data) {
            Data _data = (Data)data;
            while(!_data.end) {
                Thread.Sleep(50);
                lock(_locker) {
                    Console.SetCursorPosition(Console.WindowLeft, Console.WindowTop);
                    Console.WriteLine(Console.WindowWidth + " " + Console.WindowHeight + "\n" + Console.WindowWidth + " " + ((Console.WindowHeight / 2) - 2));
                    Console.SetCursorPosition(0, 2);
                    Console.Write("Вывод:\n");
                    Console.SetCursorPosition(0, (1 + (Console.WindowHeight / 2)));
                    Console.Write("Ввод:\n");
                    Console.Write(_data.str);
                }

                if(_data.height != Console.WindowHeight || _data.width != Console.WindowWidth) {
                    _data.height = Console.WindowHeight;
                    _data.width = Console.WindowWidth;
                    if(Console.WindowWidth >= 13 && Console.WindowHeight >= 6) {
                        Console.Clear();
                        while(_data.str.Length >= Console.WindowWidth * ((Console.WindowHeight / 2) - 2)) {
                            _data.str = _data.str.Substring(1);
                        }
                    }
                }

                if(_data.time.TimeOfDay.Subtract(DateTime.Now.TimeOfDay).TotalMilliseconds <= 50) {
                    _data.time = DateTime.Now;
                    lock(_locker) {
                        if(Console.WindowWidth >= 8 && Console.WindowHeight >= 1) {
                            Console.SetCursorPosition(Console.WindowWidth - 8, Console.WindowTop);
                        }
                        Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
                    }
                }
            }
        }

        static void JobTask(object data) {
            Data _data = (Data)data;
            string currentState = "";
            while(!_data.end) {
                Thread.Sleep(50);
                if(_data.str == currentState) {
                    continue;
                }
                else {
                    string tempStr = _data.str;
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
                    _data.modifiedStr = result;
                    currentState = _data.str;
                    lock(_locker) {
                        Console.SetCursorPosition(0, 3);
                        Console.Write(_data.modifiedStr);
                        Thread.Sleep(20);
                    }
                }
            }
        }

        static void Main() {
            ConsoleKeyInfo key;
            Console.TreatControlCAsInput = true;

            Data data = new Data();
            Thread outThread = new Thread(new ParameterizedThreadStart(OutTask));
            Thread jobThread = new Thread(new ParameterizedThreadStart(JobTask));
            outThread.Start(data);
            jobThread.Start(data);

            do {
                Thread.Sleep(20);
                Console.CursorVisible = false;
                if(Console.KeyAvailable) {
                    Console.SetCursorPosition(data.str.Length / Console.WindowWidth, (1 + (Console.WindowHeight) / 2) + (data.str.Length / Console.WindowWidth));
                    key = Console.ReadKey(true);
                    switch(key.Key) {
                        case ConsoleKey.Backspace:
                            lock(_locker) {
                                if(data.str.Length > 0) {
                                    data.str = data.str.Substring(0, data.str.Length - 1);
                                }
                                Console.Clear();
                                Thread.Sleep(1);
                            }
                            break;

                        case ConsoleKey.Escape:
                            data.end = true;
                            outThread.Join();
                            jobThread.Join();
                            return;

                        default:
                            data.str += key.KeyChar;
                            if(data.str.Length >= Console.WindowWidth * ((Console.WindowHeight / 2) - 2)) {
                                data.str = data.str.Substring(1);
                            }
                            break;
                    }
                }
            } while(true);
        }
    }
}