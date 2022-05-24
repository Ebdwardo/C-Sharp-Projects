using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project2
{
    class TicketBroker
    {
        public static event orderCreatedEvent orderCreated; 
        public static Random rand = new Random();

        public void ticketBrokerFunc()
        {
            while(Theater.threadIsRunning == true)
            {              
                createOrder(Thread.CurrentThread.Name);
            }
        }

        private void createOrder(string senderID)
        {
           
            orderCreated(); 
        }

        public void orderProcessed(string senderID, int amountToCharge, int price, int amount)
        {
            
        }

        public void ticketsOnSale(int p, string senderID) 
        {
            
        }
    }
}
