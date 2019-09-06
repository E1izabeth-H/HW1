using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleTotal
{
    static class SaleTotal
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Elizabeth Haskins
            //Define Variables
            string product;
            string ticketnumAsString;
            string ticketpriceAsString;
            double numTicket, numTicketPrice, subtotal, total;

            //Get user input
            Console.WriteLine("What is the product name of the item you are purchasing?");
            product = Console.ReadLine();

            Console.WriteLine("How Many Football Ticket's do you want to buy?");
            ticketnumAsString = Console.ReadLine();

            Console.WriteLine("What is the price for each Football Ticket?");
            ticketpriceAsString = Console.ReadLine();

            //Convert strings to number data types
            numTicket = Convert.ToDouble(ticketnumAsString);

            numTicketPrice = Convert.ToDouble(ticketpriceAsString);

            subtotal = numTicket * numTicketPrice;

            double salestax = 0.085;
            salestax = subtotal * salestax;

            total = subtotal + salestax;

            string subtotalSentence = "Your subtotal for your bill is " + subtotal.ToString("C2");
            string salestaxSentence = "Your sales tax for your bill is " + salestax.ToString("C2");
            string totalSentence = "Your total for your bill is " + total.ToString("C2");

            //Output

            Console.WriteLine(subtotalSentence);
            Console.WriteLine(salestaxSentence);
            Console.WriteLine(totalSentence);

            Console.ReadKey();



        }
    }
}
