using System;

namespace FlowControl
{
    internal class StringRepeater
    {
        public StringRepeater()
        {
            // Does this save the value on the selection variable or just a reference?
            // Is there another way to initialize the variable?
            // Receiving the input
            string selection = Util.AskForSelection("Input your text to be repeated: ");
            string repeatedText = "";

            // Looping 10 times and adding to the variable
            for (int i = 0; i < 10; i++)
            {
                //                repeatedText += selection;
                Console.Write($"{i + 1}, {selection},");
            }

            // Output
          //  Console.WriteLine(repeatedText);

        }
    }
}