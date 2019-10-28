using System;

namespace FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                // Starting the menu
                Console.WriteLine();
                Console.WriteLine("***************************************************************");
                Console.WriteLine("Welcome to the main menu. Please navigate by choosing a number!");
                Console.WriteLine("1. Check the price of a ticket for 1 person");
                Console.WriteLine("2. Check the price of tickets for a group");
                Console.WriteLine("3. Make your text repeat itself 10 times");
                Console.WriteLine("4. Write a sentence and the system will print out your third word");
                Console.WriteLine("0. Close the program");
                Console.WriteLine("***************************************************************");
                
                // Asking for input
                string selection = Util.AskForSelection("Your selection: ");

                // Terminating the program if 0 is chosen
                if (selection == "0") break;

                // Switch calling different classes according to the input
                switch (selection)
                {
                    case "1":
                        Console.WriteLine();
                        CinemaTickets.ShowPrice();
                        break;
                    case "2":
                        Console.WriteLine();
                        CinemaTicketsGroup.ShowPrice();
                        break;
                    case "3":
                        Console.WriteLine();
                        StringRepeater.PrintString();
                        break;
                    case "4":
                        Console.WriteLine();
                        ThirdWordChooser.SplitAndPrint();
                        break;
                    default:
                        Console.WriteLine("This is not a valid selection. Please try again!");
                        Console.WriteLine("------------------------------------------------");
                        break;
                }

            }
            while (true);
        }
    }
}
