using System;

namespace FlowControl
{
    public static class Util
    {
        // Asking for a prompt and returning the input otherwise keep on asking
        internal static string AskForSelection(string prompt, int numberOfWords = 0)
        {
            bool doWhile = true;
            string input;
            do
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    doWhile = false;
                }
            }
            while (doWhile);

            return input;
        }

        // Asking for a number and parsing to an integer otherwise keep on asking
        internal static uint AskForInt(string prompt)
        {
            bool conversionSuccess = true;
            uint output;
            do
            {
                string input = AskForSelection(prompt);
                conversionSuccess = uint.TryParse(input, out output);
                if(!conversionSuccess)
                {
                    Console.WriteLine("Wrong format only numbers please!");
                }
            }
            while (!conversionSuccess);
            return output;
        }
    }
}