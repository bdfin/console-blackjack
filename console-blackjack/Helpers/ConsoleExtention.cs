using ConsoleBlackjack.Common;
using System;
using System.Threading;

namespace ConsoleBlackjack.Helpers
{
    public static class ConsoleExtention
    {
        public static void Scroll(string message)
        {
            string[] textLines = message.Split(
                                new[] { Environment.NewLine },
                                StringSplitOptions.None);

            for (int i = 0; i < textLines.Length; i++)
            {
                foreach (char character in textLines[i])
                {
                    Console.Write(character);
                    Thread.Sleep(50);
                }

                bool isLastLine = i == textLines.Length - 1;

                if (isLastLine is false)
                {
                    Thread.Sleep(1000);
                }
                else
                {
                    WriteSuspentionPoints((int)ScrollSpeed.Medium);
                }

                Console.WriteLine();
            }
        }

        private static void WriteSuspentionPoints(int scrollSpeed)
        {
            for (int x = 0; x < 3; x++)
            {
                Console.Write(".");
                Thread.Sleep(scrollSpeed);
            }
        }

        public static void Continue()
        {
            Scroll(StandardMessages.Continue);
            Console.ReadKey();
            Console.Clear();
        }

        public static void WriteErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
