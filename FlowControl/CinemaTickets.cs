using System;

namespace FlowControl
{
    internal class CinemaTickets
    {
        public static void ShowPrice()
        {
            // Getting the input and calling the calculate age method
            uint input = Util.AskForInt("Input the age of the person:");
            CinemaTickets.CalculatePriceByAge(input);
        }

        // Getting an integer and returning the price of the ticket based on age
        public static uint CalculatePriceByAge(uint input)
        {
            if (input < 20)
            {
                if (input < 5)
                {
                    Console.WriteLine("Kids under 5 years old have free entrance");
                    return 0;
                }
                else
                {
                    Console.WriteLine("The price for the youth ticket is 80kr");
                    return 80;
                }
            }
            else if (input >= 20 && input <= 64)
            {
                Console.WriteLine("The price for the standard ticket is 120kr");
                return 120;
            }
            else if (input > 64 && input <= 100)
            {
                Console.WriteLine("The price for the retired ticket is 90kr");
                return 90;
            }
            else
            {
                Console.WriteLine("People over 100 years old have free entrance");
                return 0;
            }
        }
    }
}