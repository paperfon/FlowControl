using System;

namespace FlowControl
{
    internal class CinemaTicketsGroup
    {

        public CinemaTicketsGroup()
        {
            // Why it complains for total price but not for ticketPrice??
            // Defining variables to be used
            uint movieGoers = Util.AskForInt("How many persons are going to the movies?");
            uint totalPrice = 0;
            uint ticketPrice;

            // Looping through the number of movie goers
            for (int i = 0; i < movieGoers; i++)
            {
                Console.WriteLine();
                uint input = Util.AskForInt($"Input the age of person number {i+1}:");
                ticketPrice = CinemaTickets.CalculatePriceByAge(input);
                totalPrice += ticketPrice;
            }

            // Final output of the total price
            Console.WriteLine();
            Console.WriteLine($"The total price of the tickets is: {totalPrice}kr");
        }
    }
}