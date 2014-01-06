using System;

namespace Util {

    public static class Out {
        private const ConsoleColor STANDARD = ConsoleColor.White;

        public static void Green(string message) { write(ConsoleColor.Green, message); }

        public static void Red(string message) { write(ConsoleColor.Red, message); }

        public static void DarkYellow(string message) { write(ConsoleColor.DarkYellow, message); }

        public static void Write(string message) { Console.WriteLine(message); }

        public static void Head(string message) { Console.WriteLine("========== " + message + " =========="); }

        private static void write(ConsoleColor c, string m) {
            Console.ForegroundColor = c;
            Console.WriteLine(m);
            Console.ForegroundColor = STANDARD;
        }
    }
}