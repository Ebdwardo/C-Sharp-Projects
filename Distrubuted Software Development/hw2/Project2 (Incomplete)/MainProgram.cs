using System;
using System.Threading;

namespace Project2
{
    public delegate void orderProcessedEvent(string senderID, int amountToCharge, int price, int quantity);
    public delegate void orderCreatedEvent();
    
    public class MainProgram
    {
        public delegate void priceCutEvent(int p);
        public static event priceCutEvent priceCut;
        public static MultiCellBuffer cells;
        

        static void Main(string[] args)
        {
            Theater theater = new Theater();
            TicketBroker ticketBroker = new TicketBroker();

            cells = new MultiCellBuffer(2); 

            Thread theaterThread = new Thread(new ThreadStart(theater.theaterFunction));
        }
    }
}

