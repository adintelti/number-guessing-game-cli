using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGameCLI
{
    public static class ConsoleMessages
    {
        public static void PrintInfo(string info)
        {
            Console.WriteLine(info);
            Console.ResetColor();
        }

        public static void PrintError(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ResetColor();
        }

        public static void PrintWin(string command)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(command);
            Console.ResetColor();
        }
    }
}
