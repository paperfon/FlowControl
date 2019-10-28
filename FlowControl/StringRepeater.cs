using System;

namespace FlowControl
{
    internal class StringRepeater
    {
        public static void PrintString()
        {
            // Receiving the input
            string selection = Util.AskForSelection("Input your text to be repeated: ");

            // Looping 10 times and adding to the variable
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. {selection}, ");
            }
        }
    }
}