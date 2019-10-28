using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowControl
{
    internal class ThirdWordChooser
    {
        public static void SplitAndPrint()
        {
            bool doWhile = true;
            string[] words;

            do
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
                words = tempList.ToArray();

                // Make sure the sentence has at least three words
                if (words.Count() < 3)
                {
                    Console.WriteLine("The sentence needs to have at least three words!");
                } else
                {
                    doWhile = false;
                }

            } while (doWhile);

            // Final output of the third word
            Console.WriteLine("The third word is: " + words[2]);
        }
    }
}