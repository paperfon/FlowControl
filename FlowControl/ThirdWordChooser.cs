using System;
using System.Collections.Generic;

namespace FlowControl
{
    internal class ThirdWordChooser
    {
        public ThirdWordChooser()
        {
            // Saving the input in an array and splitting it
            string[] sentence = Util.AskForSelection("Input your sentence: ").Split(null);

            // Creating a new temporary list to store words only
            var tempList = new List<string>();

            // Removing the blank spaces and adding words to the list
            foreach (var word in sentence)
            { 
                if (!string.IsNullOrEmpty(word))
                {
                    tempList.Add(word);
                }
            }
            // Turning the list back to an array
            var words = tempList.ToArray();

            // Final output of the third word
            Console.WriteLine("The third word is: " + words[2]);

        }
    }
}